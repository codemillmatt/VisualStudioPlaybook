using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight
{
    public interface ICourse
    {
        public string CourseName { get; set; }

        public void Rate(int rating);

        public WatchStatus ChangePlayStatus(WatchStatus newWatchStatus);
    }

    public enum WatchStatus
    {
        Playing,
        Paused,
        Stopped
    }
}
