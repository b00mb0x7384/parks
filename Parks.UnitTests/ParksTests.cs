using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parks.Testing
{
    [TestClass]
    public class ParksTest
    {
        [TestMethod]
        public void testGenerateParks_generatesAPark()
        {
            Park samplePark = new Park("27", "OSSWALD PARK", "Basketball, golf & athletics facilities can all be found in thi","someImage.jpg", "33311","0", "0");

            //arrage

            //act
            //assert

            Assert.AreEqual(samplePark.name, "OSSWALD PARK");


        }

        [TestMethod]
        public void testSearchUserControl()
        {
            var sUCVar = new searchUserControl();
            Assert.AreEqual(sUCVar.mainDisplayLabel.Text, "Search for a Park");

        }

        [TestMethod]
        public void testViewPark()
        {
            var component = new viewParkControl();
            Assert.AreEqual(component.mainDisplayLabel.Text, "Park Information");

        }
        [TestMethod]
        public void tesRecControl()
        {
            var component = new recVisitControl();
            Assert.AreEqual(component.mainDisplayLabel.Text, "Record a visit to this park?");

        }

    }
}
