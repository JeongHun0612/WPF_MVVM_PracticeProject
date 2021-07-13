using System.Windows;

namespace PracticeCode.ViewModel
{
    public class TitleViewModel : Notifier
    {
        public TitleViewModel()
        {
            MainViewModel.titleViewModel = this;
            this.commandExitClick = new DelegateCommand(ExitClick);
            this.commandMaximizeClick = new DelegateCommand(MaximizeClick);
            this.commandMinimizeClick = new DelegateCommand(ExitClick);
        }

        private string text = "계산기";
        private DelegateCommand commandExitClick = null;
        private DelegateCommand commandMaximizeClick = null;
        private DelegateCommand commandMinimizeClick = null;

        public string Text
        {
            get { return this.text; }
            set { this.text = value; Notify("Text"); }
        }
        public DelegateCommand CommandExitClick
        {
            get => this.commandExitClick;
            set => this.commandExitClick = value;
        }
        public DelegateCommand CommandMaximizeClick
        {
            get => this.commandMaximizeClick;
            set => this.commandMaximizeClick = value;
        }
        public DelegateCommand CommandMinimizeClick
        {
            get => this.commandMinimizeClick;
            set => this.commandMinimizeClick = value;
        }
        public WindowState WindowState { get; private set; }

        private void ExitClick(object obj)
        {
            //this.Close();
            //Environment.Exit(0);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void MaximizeClick(object obj)
        {
            /*
            Window window = obj as Window;
            window = WindowState.Minimized;
            this.WindowState = WindowState.Maximized;
            */
        }
    }
}