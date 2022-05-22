namespace Pluralsight
{
    public class Course : ICourse
    {
        public string CourseName { get; set; }

        public WatchStatus ChangePlayStatus(WatchStatus newWatchStatus)
        {
            return newWatchStatus;
        }

        public void Rate(int rating)
        {
            if (rating < 0 || rating > 5)
                throw new ArgumentException();
        }

    }
}