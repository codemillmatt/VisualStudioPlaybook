using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pluralsight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.Tests
{
    [TestClass()]
    public class CourseTests
    {
        [TestMethod()]
        public void ChangePlayStatusTest()
        {
            Course psCourse = new Course();

            WatchStatus newWatchStatus = psCourse.ChangePlayStatus(WatchStatus.Playing);

            Assert.AreEqual(WatchStatus.Playing, newWatchStatus);
        }

        [TestMethod()]
        public void RateTest()
        {
            Course psCourse = new Course();

            Assert.ThrowsException<ArgumentException>(() => psCourse.Rate(0));
        }
    }
}