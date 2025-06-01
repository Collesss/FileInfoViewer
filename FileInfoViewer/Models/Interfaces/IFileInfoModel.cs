using System.ComponentModel;

namespace FileInfoViewer.Models.Interfaces
{
    public interface IFileInfoModel : INotifyPropertyChanged
    {
        public string FileName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public long Size { get; set; }

        public uint HashCRC32 { get; set; }
    }
}
