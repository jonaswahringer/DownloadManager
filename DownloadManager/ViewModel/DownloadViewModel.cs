using System;
namespace DownloadManager.ViewModel
{
    public class DownloadViewModel: INotifyPropertyChanged
    {
        #region properties
        public DownloadModel downloadModel = new DownloadModel();
        public 
        #endregion

        #region commands
        public ICommand exitCommand { get; private set; }
        public ICommand downloadCommand { get; set; }
        #endregion

    }
}
