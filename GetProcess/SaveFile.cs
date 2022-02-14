using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace GetProcess
{
    internal class SaveFile
    {
         private static string path = string.Format(@"C:\Users\{0}\Documents\file.csv", Environment.UserName);
        //private static string path = @"D:\file.csv";

        public void CreateFile(string str)
        {
            using (var fs = File.Create(path))
            {
                byte[] array = System.Text.Encoding.UTF8.GetBytes(str);
                fs.Write(array, 0, array.Length);
            }
        }

        public void OpenFile()
        {
            Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            oExcel.Visible = true;
            Excel.Workbooks wbs = oExcel.Workbooks;
            Excel.Worksheet worksheet = oExcel.ActiveSheet;
            wbs.OpenText(path, DataType: Excel.XlTextParsingType.xlDelimited, Semicolon: true);
        }
    }
}
