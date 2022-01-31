using ExcelDataReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.TestScript.ExcelDataReader
{
    [TestClass]
    public class TestExcelData
    {
        [TestMethod]
        public void ExcelDataTest()
        {
            FileStream stream = new FileStream(@"C:\Users\Franco Petruccelli\source\repos\SeleniumWebDriver\UnitTestProject1\DataSet.xlsx", FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            DataTable table = reader.AsDataSet().Tables["Sheet1"];
            Console.WriteLine("Data: " + table.Rows[0][0]);
        }
    }
}
