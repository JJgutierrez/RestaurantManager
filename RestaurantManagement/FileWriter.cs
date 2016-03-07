using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace RestaurantManagement
{
    class FileWriter
    {
        public void JsonWriter(string filepath, List<Employee> datalist)
        {
            Console.WriteLine("updating data.......");
            string data = JsonConvert.SerializeObject(datalist);
            File.WriteAllText(filepath, data);
            Console.ReadLine();
        }
        public void CSVFileWriter(DataTable dtDataTablesList, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            int iColCount = dtDataTablesList.Columns.Count;

            for (int i = 0; i < iColCount; i++)
            {
                sw.Write(dtDataTablesList.Columns[i]);
                if (i < iColCount - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);

            // Now write all the rows.

            foreach (DataRow dr in dtDataTablesList.Rows)
            {
                for (int i = 0; i < iColCount; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        sw.Write(dr[i].ToString());
                    }
                    if (i < iColCount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();     
        }
        public void CreatedReport(string report, string fileReportPath)
        {
            File.AppendAllText(fileReportPath, report);
        }
        
    }
}
