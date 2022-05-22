using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight
{
    public class SearchService : ISearchService
    {
        public IEnumerable<ICourse> SearchCourse(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return new Course[] { };

            if (searchTerm.Contains("visual studio", StringComparison.OrdinalIgnoreCase))
                return new Course[] { new Course { CourseName = "Visual Studio 2022 Playbook" } };
            else
                return new Course[] { new Course { CourseName = "Demonstrating the Business Value of Power Apps" } };
        }
    }
}
