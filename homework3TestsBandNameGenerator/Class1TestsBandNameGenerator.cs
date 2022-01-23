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
        public void bandNameGeneratorForNullOrEmpty()
        {
            Assert.AreEqual("is null", bandName.bandNameGenerator(""));
            Assert.AreEqual("is null", bandName.bandNameGenerator(null));
        }
        [TestMethod()]
        public void bandNameGeneratorForThe()
        {
            Assert.AreEqual("The Knife", bandName.bandNameGenerator("knife"));
            Assert.AreEqual("The Bed", bandName.bandNameGenerator("bed"));
        }
        [TestMethod()]
        public void bandNameGeneratorForRepleate()
        {
            Assert.AreEqual("Tartart", bandName.bandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", bandName.bandNameGenerator("sandles"));
        }
    }
}