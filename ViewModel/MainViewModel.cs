using System;
using System.Windows;

namespace PracticeCode.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.commandDragMove = new DelegateCommand(DragMove);
        }

        public static TitleViewModel titleViewModel { get; set; } = null;
        public static ResultContentViewModel resultContentViewModel { get; set; } = null;
        public static MenuBarViewModel menuBarViewModel { get; set; } = null;
        public static SelectedButtonViewModel selectedButtonViewModel { get; set; } = null;

        private DelegateCommand commandDragMove = null;

        public DelegateCommand CommandDragMove
        {
            get => this.commandDragMove;
            set => this.commandDragMove = value;
        }

        private void DragMove(object obj)
        {
            MainWindow mainWindow = obj as MainWindow; // obj as MainWindow ?
            mainWindow.DragMove();
        }
    }
}
