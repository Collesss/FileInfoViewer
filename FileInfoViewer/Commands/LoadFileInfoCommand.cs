using FileInfoViewer.Models.Interfaces;
using System.IO;
using System.IO.Hashing;

namespace FileInfoViewer.Commands
{
    public class LoadFileInfoCommand : BaseCommand
    {
        private readonly IFileInfoModel _fileInfoModel;

        public LoadFileInfoCommand(IFileInfoModel fileInfoModel) 
        {
            _fileInfoModel = fileInfoModel ?? throw new ArgumentNullException(nameof(fileInfoModel));
        }

        public override void Execute(object parameter)
        {
            FileInfo fileInfo = new FileInfo(parameter as string);

            if (fileInfo.Exists)
            {
                _fileInfoModel.FileName = fileInfo.Name;
                _fileInfoModel.CreateDate = fileInfo.CreationTime;
                _fileInfoModel.LastModifiedDate = fileInfo.LastWriteTime;
                _fileInfoModel.Size = fileInfo.Length;
                _fileInfoModel.HashCRC32 = BitConverter.ToUInt32(Crc32.Hash(File.ReadAllBytes(fileInfo.FullName)));

                Thread.Sleep(5000);
            }

        }
    }
}
