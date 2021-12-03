using System;

namespace DownloadManager.Model
{
    public class DownloadModel
    {
        public string URL { get; set; } = string.Empty;
        public string HTMLCode { get; set; } = string.Empty;
        public DateTime timeInterval = new DateTime();

        public static int runningThreads = 0;
        private static object totalAmountLock = new object();
    }
}
