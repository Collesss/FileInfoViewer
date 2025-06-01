using System.Windows.Input;

namespace FileInfoViewer.Commands
{
    public abstract class BaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) =>
            true;

        public abstract void Execute(object parameter);
    }
}
