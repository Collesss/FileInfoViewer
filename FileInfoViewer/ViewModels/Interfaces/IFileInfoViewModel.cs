using FileInfoViewer.Models.Interfaces;
using System.ComponentModel;
using System.Windows.Input;

namespace FileInfoViewer.ViewModels.Interfaces
{
    public interface IFileInfoViewModel : INotifyPropertyChanged
    {
        public IFileInfoModel FileInfo { get; set; }

        public ICommand LoadFileInfoCommand { get; set; }
    }
}
