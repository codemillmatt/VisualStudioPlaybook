﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight
{
    public interface ISearchService
    {
        public IEnumerable<ICourse> SearchCourse(string searchTerm);
    }
}