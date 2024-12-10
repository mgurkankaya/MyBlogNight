namespace MyBlogNight.PresentationLayer.Helpers
{
    public static class TimeHelper
    {
        public static string GetTimeAgo(DateTime createdDate)
        {
            var timeSpan = DateTime.Now - createdDate;

            if (timeSpan.TotalMinutes < 1)
                return "Az önce";
            else if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} dakika önce";
            else if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} saat önce";
            else
                return $"{(int)timeSpan.TotalDays} gün önce";
        }
    }
}
