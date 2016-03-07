using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RestaurantManagement
{
    class FileReader
    {
        public List<Employee> JsonFileReader(string filepath)
        {

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string readJson = File.ReadAllText(filepath);
            List<Employee> myList = JsonConvert.DeserializeObject<List<Employee>>(readJson);
            if (myList == null)
                myList = new List<Employee>();
            return myList;
        }
        public DataTable GetCsvData(string filePath)
        {
            StreamReader sreader = new StreamReader(filePath);
            DataTable datatable = new DataTable();
            int rowCount = 0;
            string[] columnNames = null;
            string[] streamdataValues = null;
            while (!sreader.EndOfStream)
            {
                string streamRowData = sreader.ReadLine().Trim();
                if (streamRowData.Length > 0)
                {
                    streamdataValues = streamRowData.Split(',');
                    if (rowCount == 0)
                    {
                        rowCount = 1;
                        columnNames = streamdataValues;
                        foreach (string csvHeader in columnNames)
                        {
                            DataColumn datacolumn = new DataColumn(csvHeader.ToUpper(), typeof(string));
                            datacolumn.DefaultValue = string.Empty;
                            datatable.Columns.Add(datacolumn);
                        }
                    }
                    else
                    {
                        DataRow datarow = datatable.NewRow();
                        for (int i = 0; i < columnNames.Length; i++)
                        {
                            datarow[columnNames[i]] = streamdataValues[i] == null ? string.Empty : streamdataValues[i].ToString();
                        }
                        datatable.Rows.Add(datarow);
                    }

                }
            }
            sreader.Close();
            sreader.Dispose();
            return datatable;
        }
        public void DisplayData(DataTable myDataTable)
        {
            foreach (DataRow row in myDataTable.Rows)
            {
                Console.WriteLine();
                for (int x = 0; x < myDataTable.Columns.Count; x++)
                {
                    Console.Write(row[x].ToString() + " ");
                }
            }
        }
        public void OpenPdfMenu(string PDFPath)
        {
            Process.Start(PDFPath);
        }
        public void OpenReport(string filePath)
        {
            string report = File.ReadAllText(filePath).ToString();
            Console.WriteLine(report);
        }


    }
}
