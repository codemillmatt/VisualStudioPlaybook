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
        public void ChangeToPlayStatusTest()
        {
            Course psCourse = new Course();

            WatchStatus newWatchStatus = psCourse.ChangePlayStatus(WatchStatus.Playing);

            Assert.AreEqual(WatchStatus.Playing, newWatchStatus);
        }

        [TestMethod()]
        public void ChangeToPauseStatusTest()
        {
            Course psCourse = new Course();

            WatchStatus newWatchStatus = psCourse.ChangePlayStatus(WatchStatus.Paused);

            Assert.AreEqual(WatchStatus.Paused, newWatchStatus);
        }

        [TestMethod()]
        public void ChangeToStopStatusTest()
        {
            Course psCourse = new Course();

            WatchStatus newWatchStatus = psCourse.ChangePlayStatus(WatchStatus.Stopped);

            Assert.AreEqual(WatchStatus.Stopped, newWatchStatus);
        }

        [TestMethod()]
        public void RateToLowExceptionTest()
        {
            Course psCourse = new Course();

            Assert.ThrowsException<ArgumentException>(() => psCourse.Rate(0));
        }

        [TestMethod()]
        public void RateToHighExceptionTest()
        {
            Course psCourse = new Course();

            Assert.ThrowsException<ArgumentException>(() => psCourse.Rate(6));
        }
    }
}