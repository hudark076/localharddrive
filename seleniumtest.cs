using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumn_unitannotation
{
    [TestFixture]
    class seleniumtest
    {
        [Test]
        public void Verifyingtittleofpagepass()
        {
            string expectedTitle = "Facebook - Log In or Sign Up";
            string actualtitle = driver.title;

            Assert.Areequal
        }

    }
}
