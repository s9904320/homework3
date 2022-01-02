using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3.TestsBandNameGenerator
{
    [TestClass()]
    public class Class1TestsBandNameGenerator
    {

        [TestMethod()]
        public void bandNameGeneratorTestBandNameGenerator()
        {
            Assert.AreEqual("is null", Class1.bandNameGenerator(""));
            Assert.AreEqual("is null", Class1.bandNameGenerator(null));
            Assert.AreEqual("The Knife", Class1.bandNameGenerator("knife"));
            Assert.AreEqual("Tartart", Class1.bandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", Class1.bandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", Class1.bandNameGenerator("bed"));
        }
    }
}