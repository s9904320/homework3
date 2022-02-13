using Microsoft.VisualStudio.TestTools.UnitTesting;
using bandnamecreater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandnamecreater.TestsBandNameGenerator
{
    [TestClass()]
    public class TestsBandNameGenerator
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
        }
        [TestMethod()]
        public void bandNameGeneratorForRepleate()
        {
            Assert.AreEqual("Sandlesandles", bandName.bandNameGenerator("sandles"));
        }
    }
}