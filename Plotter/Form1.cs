using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Plotter
{
    public partial class Form1 : Form
    {
        private int filterLength;
        private Queue<DataValue> filterData;
        public Form1()
        {
            InitializeComponent();
            filterLength = 5;
            filterData = new Queue<DataValue>();
            chart1.Series.Add("Value");
            chart1.Series["Value"].YAxisType = AxisType.Primary;
            chart1.Series["Value"].ChartType = SeriesChartType.FastLine;
            chart1.Series.Add("Temp");
            chart1.Series["Temp"].YAxisType = AxisType.Secondary;
            chart1.Series["Temp"].ChartType = SeriesChartType.FastLine;

            chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
        }

        private void buttonQuery_Click(object sender, EventArgs e)
        {
            chart1.Series["Temp"].Points.Clear();
            chart1.Series["Value"].Points.Clear();

            if (radioButtonSqlserver.Checked)
            {
                string connectionString = "Data Source = "+textBoxIP.Text+";Network Library = DBMSSOCN;Initial Catalog = "+textBoxDatabase.Text+";User ID = "+textBoxUser.Text+";Password = "+textBoxPwd.Text;

                //string connectionString = "Server=(LocalDB)\\MSSQLLocalDB; Integrated Security=true;Initial Catalog=bgk";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MidValueFilter filter1 = new MidValueFilter(filterLength);
                    MidValueFilter filter2 = new MidValueFilter(filterLength);
                    MidValueFilter filter3 = new MidValueFilter(filterLength - 2);
                    filterData.Clear();
                    SqlCommand command = new SqlCommand(textBoxSqlStatement.Text, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        string stamp = "";
                        double value = 0;
                        double temp = 0;

                        while (reader.Read())
                        {
                            stamp = reader.GetDateTime(0).ToString();
                            //stamp = reader.GetString(0);
                            value = reader.GetDouble(1);
                            if (checkBoxDiplayTemp.Checked)
                            {
                                temp = reader.GetDouble(2);
                            }
                            if (checkBoxFirstFilter.Checked)
                            {
                                value = filter1.GetFilteredValue(value);
                            }
                            if (checkBoxSecondFilter.Checked)
                            {
                                value = filter2.GetFilteredValue(value);
                            }
                            if (checkBoxThirdFilter.Checked)
                            {
                                value = filter3.GetFilteredValue(value);
                            }
                            DataValue dv = new DataValue(stamp, value,temp);
                            filterData.Enqueue(dv);
                            chart1.Series["Value"].Points.AddXY(stamp, value);
                            if (checkBoxDiplayTemp.Checked)
                            {
                                chart1.Series["Temp"].Points.AddXY(stamp, temp);
                                //chart1.Series["Temp"].Points;
                            }
                        }
                        reader.Close();
                    }
                    connection.Close();
                }
            }
            else
            {
                using (SQLiteConnection connection = new SQLiteConnection("DataSource= PuliCurrent.db"))
                {
                    connection.Open();
                    MidValueFilter filter1 = new MidValueFilter(filterLength);
                    MidValueFilter filter2 = new MidValueFilter(filterLength);
                    MidValueFilter filter3 = new MidValueFilter(filterLength - 2);
                    filterData.Clear();
                    SQLiteCommand command = new SQLiteCommand(textBoxSqlStatement.Text, connection);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string stamp = reader.GetString(0);
                            double value = reader.GetDouble(1);
                            if (checkBoxFirstFilter.Checked)
                            {
                                value = filter1.GetFilteredValue(value);
                            }
                            if (checkBoxSecondFilter.Checked)
                            {
                                value = filter2.GetFilteredValue(value);
                            }
                            if (checkBoxThirdFilter.Checked)
                            {
                                value = filter3.GetFilteredValue(value);
                            }
                            DataValue dv = new DataValue(stamp, value,0);
                            filterData.Enqueue(dv);
                            chart1.Series[0].Points.AddXY(stamp, value);
                        }
                    }
                    connection.Close();
                }
            } 
            // Adjust Y & X axis scale
            chart1.ResetAutoValues();

            // Invalidate chart
            chart1.Invalidate();
        }

        private void numericUpDownWindowSize_ValueChanged(object sender, EventArgs e)
        {
            filterLength = (int)numericUpDownWindowSize.Value;
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            string fileName = textBoxFileName.Text + ".csv";
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                while (filterData.Count > 0)
                {
                    DataValue dv = filterData.Dequeue();
                    string line = dv.TimeStamp + "," + Math.Round(dv.Value, 3).ToString() + ","+dv.Temp+"\r\n";
                    sw.Write(line);
                }
                
                sw.Close();
                MessageBox.Show("导出成功！");
            }            
        }

        private DataTable GetTableSchema()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                //new DataColumn("ID",typeof(int)),
                //new DataColumn("SensorId",typeof(string)),
                new DataColumn("Stamp",typeof(System.DateTime)),
                //new DataColumn("Type",typeof(string)),
                new DataColumn("Value",typeof(Single))
            });
            return dt;
        }

        //private DataTable GetTableSchema()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.AddRange(new DataColumn[] {
        //        //new DataColumn("ID",typeof(int)),
        //        new DataColumn("SensorId",typeof(string)),
        //        new DataColumn("Stamp",typeof(System.DateTime)),
        //        new DataColumn("Type",typeof(string)),
        //        new DataColumn("Value",typeof(Single))
        //    });
        //    return dt;
        //}

        private void InsertData(DataTable dt, string tableName)
        {
            string connectionString = "Data Source = " + textBoxIP.Text + ";Network Library = DBMSSOCN;Initial Catalog = " + textBoxDatabase.Text + ";User ID = " + textBoxUser.Text + ";Password = " + textBoxPwd.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
                    bulkCopy.DestinationTableName = tableName;
                    bulkCopy.BatchSize = dt.Rows.Count;
                    //bulkCopy.BulkCopyTimeout
                    conn.Open();

                    if (dt != null && dt.Rows.Count != 0)
                    {
                        bulkCopy.WriteToServer(dt);
                    }

                    conn.Close();
                    //saveDataSuccess = true;
                }
            }
            catch (Exception ex)
            {
                //saveDataSuccess = false;
                //if (textBoxLog.InvokeRequired)
                //{
                //    textBoxLog.BeginInvoke(new MethodInvoker(() =>
                //    {
                //        textBoxLog.AppendText(ex.Message + "\r\n");
                //    }));
                //}
                //else
                //{
                //    textBoxLog.AppendText(ex.Message + "\r\n");
                //}
            }
        }

        private void buttonExport2Sqlserver_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = " + textBoxIP.Text + ";Network Library = DBMSSOCN;Initial Catalog = " + textBoxDatabase.Text + ";User ID = " + textBoxUser.Text + ";Password = " + textBoxPwd.Text;
            DataTable dt = GetTableSchema();
            while (filterData.Count > 0)
            {
                DataValue dv = filterData.Dequeue();
                DataRow row = dt.NewRow();
                row[0] = DateTime.Parse(dv.TimeStamp);
                row[1] = dv.Value;
                dt.Rows.Add(row);
            }

            string tableName = textBoxTableName.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
                    bulkCopy.DestinationTableName = tableName;
                    bulkCopy.BatchSize = dt.Rows.Count;
                    //bulkCopy.BulkCopyTimeout
                    conn.Open();

                    if (dt != null && dt.Rows.Count != 0)
                    {
                        bulkCopy.WriteToServer(dt);
                    }

                    conn.Close();
                    //saveDataSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n");
                return;
            }
            MessageBox.Show("导出成功！");
        }
    }
    public class DataValue
    {
        
        public string TimeStamp { get; set; }
        public double Temp { get; set; }
        public double Value { get; set; }

        public DataValue(string stamp, double value,double temp)
        {
            
            TimeStamp = stamp;
            Temp = temp;
            Value = value;
        }
    }


    //public class DataValue
    //{
    //    public string SensorId { get; set; }
    //    public string TimeStamp { get; set; }
    //    public string ValueType { get; set; }
    //    public double Value { get; set; }

    //    public DataValue(string sensorId,string stamp,string valueType,double value)
    //    {
    //        SensorId = sensorId;
    //        TimeStamp = stamp;
    //        ValueType = valueType;
    //        Value = value;
    //    }
    //}
}
