using FileInfoViewer.Commands;
using FileInfoViewer.Models;
using FileInfoViewer.Models.Interfaces;
using FileInfoViewer.ViewModels.Interfaces;
using System.Windows.Input;

namespace FileInfoViewer.ViewModels
{
    public class FileInfoViewModel : BaseViewModel, IFileInfoViewModel
    {
        private IFileInfoModel _fileInfo;

        public IFileInfoModel FileInfo
        {
            get => _fileInfo;
            set
            {
                _fileInfo = value;
                OnPropertyChanged();
            }
        }


        private ICommand _loadFileInfoCommand;

        public ICommand LoadFileInfoCommand 
        { 
            get => _loadFileInfoCommand;
            set 
            {
                _loadFileInfoCommand = value;
                OnPropertyChanged();
            } 
        }

        public FileInfoViewModel()
        {
            _fileInfo = new FileInfoModel();
            _loadFileInfoCommand = new LoadFileInfoCommand(_fileInfo);

            if (Environment.GetCommandLineArgs().Skip(1).SingleOrDefault() is string arg)
                _loadFileInfoCommand.Execute(arg);
        }
    }
}
