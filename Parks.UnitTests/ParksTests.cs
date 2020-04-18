using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parks.Testing
{
    [TestClass]
    public class ParksTest
    {
        [TestMethod]
        public void testGenerateParks_generatesAPark()
        {
            Park samplePark = new Park("27", "OSSWALD PARK", "Basketball, golf & athletics facilities can all be found in this large community park.", "osswald_park.jpg", "2220", "NW 21ST AVENUE", "FORT LAUDERDALE", "FL", "33311", "0", "0");

            //arrage

            //act
            //assert

            Assert.AreEqual(samplePark.name, "OSSWALD PARK");


        }
    }
}
