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
    public class SearchServiceTests
    {
        [TestMethod()]
        public void SearchCourseTest()
        {
            SearchService searchService = new SearchService();

            var course = searchService.SearchCourse("visual studio");

            Assert.AreEqual("Visual Studio 2022 Playbook", 
                course.First().CourseName);
        }
    }
}