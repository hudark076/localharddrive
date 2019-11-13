using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_calculator
{
    [TestFixture]
    class testcalculator
    {
        [Test]
        public void passAdd()
        {
            Assert.AreEqual(5, new calculator().ADD(4, 1));
        }
        
            [Test]
        public void failAdd()
        {
            Assert.AreEqual(5, new calculator().ADD(5,1));
        }

        [Test]
        public void passMinus()
        {
            Assert.AreEqual(5, new calculator().MINUS(6,1));
        }

        [Test]
        public void failMinus()
        {
            Assert.AreEqual(5, new calculator().MINUS(5, 1));
        }
    }
}
