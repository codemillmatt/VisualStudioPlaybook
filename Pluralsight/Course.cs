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
            if (rating < 1 || rating > 5)
                throw new ArgumentException();
        }

    }
}