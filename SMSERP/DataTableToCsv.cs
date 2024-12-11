using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ZCLINIC
{
    public class DataTableToCsv
    {

        public byte[] ConvertToCSV(DataTable dataTable,string fileName,dynamic hostingEnvironment)
        {
            try
            {
                fileName = Guid.NewGuid().ToString() + "_" + fileName;
                string filePath = Path.Combine(Path.Combine(hostingEnvironment.WebRootPath, "assets/Reports"), fileName);
                StreamWriter sw = new StreamWriter(filePath);
                foreach (DataColumn item in dataTable.Columns)
                {
                    sw.Write(item.ColumnName + ",");
                }
                sw.Write(sw.NewLine);
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    sw.WriteLine(string.Join(",", dataRow.ItemArray.Select(x => x.ToString().Replace(",","")).ToArray()));
                  
                }
                sw.Close();
                byte[] bytes;
                bytes = File.ReadAllBytes(filePath);
                File.Delete(filePath);
                return bytes;
            }

            catch(Exception e)
            {

                return null;
            }
        }
    }
}
