using PracticeCode.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace PracticeCode.ViewModel
{
    public class MainViewModel : Notifier
    {
        public MainViewModel()
        {
            this.commandLoaded = new DelegateCommand(Loaded);
            this.commandDragMove = new DelegateCommand(DragMove);

            Collection.Add(new TestModel("name1", "abc"));
            Collection.Add(new TestModel("name2", "abc"));
            Collection.Add(new TestModel("name3", "abc"));
            Collection.Add(new TestModel("name4", "abc"));
        }

        public static TitleViewModel titleViewModel { get; set; } = new TitleViewModel();
        public static ResultContentViewModel resultContentViewModel { get; set; } = new ResultContentViewModel();
        public static MenuBarViewModel menuBarViewModel { get; set; } = new MenuBarViewModel();
        public static SelectedButtonViewModel selectedButtonViewModel { get; set; } = new SelectedButtonViewModel();

        public static WindowState state = WindowState.Normal;

        public WindowState State
        {
            get { return state; }
            set { state = value; Notify("State"); }
        }

        private DelegateCommand commandLoaded = null;

        public DelegateCommand CommandLoaded
        {
            get => this.commandLoaded;
            set => this.commandLoaded = value;
        }

        private DelegateCommand commandDragMove = null;

        public DelegateCommand CommandDragMove
        {
            get => this.commandDragMove;
            set => this.commandDragMove = value;
        }

        // 임시
        private ObservableCollection<TestModel> collection = new ObservableCollection<TestModel>();
        public ObservableCollection<TestModel> Collection
        {
            get => this.collection;
            set => this.collection = value;
        }

        private void Loaded(object obj)
        {
            titleViewModel.delegateState += TitleViewModel_delegateState;
        }

        private void DragMove(object obj)
        {
            // obj as MainWindow ?
            MainWindow mainWindow = obj as MainWindow;
            mainWindow.DragMove();
        }

        private void TitleViewModel_delegateState(WindowState state)
        {
            this.State = state;
        }
    }
}
