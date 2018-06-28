using Microsoft.VisualStudio.TestTools.UnitTesting;
using funcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcode.Tests
{
    [TestClass()]
    public class SolutionTests
    {

        private Solution Solution = null;
        [TestInitialize]
        public void Init()
        {
            this.Solution = new Solution();
        }

        [TestMethod()]
        public void TwoSumTest()
        {




            Assert.Fail();
        }



        [TestMethod()]
        public void RESTTest()
        {

            Assert.AreEqual<string>(
              this.Solution.REST("aacecaaa"),
              "aaacecaaa");


            Assert.AreEqual<string>(
          this.Solution.REST("A"),
          "A");
            //Assert.Fail();
        }
    }
}