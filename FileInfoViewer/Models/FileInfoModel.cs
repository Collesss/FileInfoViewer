using FileInfoViewer.Models.Interfaces;

namespace FileInfoViewer.Models
{
    public class FileInfoModel : BaseModel, IFileInfoModel
    {
        private string _fileName;
        private DateTime _createDate;
        private DateTime _lastModifiedDate;
        private long _size;
        private uint _hashCRC32;

        public string FileName 
        { 
            get => _fileName;
            set 
            {
                _fileName = value;
                OnPropertyChanged();
            }
        }

        public DateTime CreateDate 
        { 
            get => _createDate;
            set 
            {
                _createDate = value;
                OnPropertyChanged();
            } 
        }

        public DateTime LastModifiedDate
        {
            get => _lastModifiedDate;
            set
            {
                _lastModifiedDate = value;
                OnPropertyChanged();
            }
        }

        public long Size 
        { 
            get => _size;
            set
            {
                _size = value;
                OnPropertyChanged();
            }
        }
        
        public uint HashCRC32 
        { 
            get => _hashCRC32;
            set 
            {
                _hashCRC32 = value;
                OnPropertyChanged();
            }
        }
    }
}
