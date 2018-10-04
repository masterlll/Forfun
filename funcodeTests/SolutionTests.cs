using Microsoft.VisualStudio.TestTools.UnitTesting;
using funcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Diagnostics;

namespace funcode.Tests
{
    [TestClass()]
    public class SolutionTests
    {

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        private Solution Solution = null;
        [TestInitialize]
        public void Init()
        {
            this.Solution = new Solution();
        }

        [TestMethod()]
        public void TwoSumTest()
        {
            int[] a = new int[2] {27,1115};
            int[] b = new int[2];
            
            Assert.AreEqual<int>(this.Solution.TwoSum(a, 9), 0);



            //Assert.Fail();
        }


        [TestMethod()]
     
      //Datasource 使用外部檔案 傳入參數
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"D:\Work\DoNET\Forfun\funcodeTests\parameters.xml", "add", DataAccessMethod.Sequential)]
        public void RESTTest()
        {

           
            string given = this.TestContext.DataRow["given"] as string;
            string expected = this.TestContext.DataRow["expected"] as string;
            string actual = this.Solution.REST(given);

            this.TestContext.WriteLine($"given:    {given}");
            this.TestContext.WriteLine($"expected: {expected}");
            this.TestContext.WriteLine($"actual:   {actual}");

            Assert.AreEqual<string>(
                actual,
                expected);

            Con();
            //一般單元測試寫法
            //  Assert.AreEqual<string>(
            //    this.Solution.REST("aacecaaa"),
            //    "aaacecaaa");


            //  Assert.AreEqual<string>(
            //this.Solution.REST("A"),
            //"A");



            //Assert.Fail();
        }

       // [Conditional("DEBUG")]
        public void Con()
        {

            Console.Write("D");
            Console.WriteLine();
        }

#if (LOCAL_DEBUG)
        
#endif

    }
}