using System;
using System.Windows;

namespace PracticeCode.ViewModel
{
    public class TitleViewModel : Notifier
    {
        public TitleViewModel()
        {
            //MainViewModel.titleViewModel = this;
            this.commandExitClick = new DelegateCommand(ExitClick);
            this.commandMaximizeClick = new DelegateCommand(MaximizeClick);
            this.commandMinimizeClick = new DelegateCommand(MinimizeClick);
        }

        public delegate void DelegateState(WindowState state);
        public event DelegateState delegateState;

        private string text = "표준 계산기";
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

        private void ExitClick(object obj)
        {
            //this.Close();
            //Environment.Exit(0);
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void MaximizeClick(object obj)
        {
            if(MainViewModel.state == WindowState.Normal)
            {
                delegateState?.Invoke(WindowState.Maximized);
            }
            else
            {
                delegateState?.Invoke(WindowState.Normal);
            }
        }
        private void MinimizeClick(object obj)
        {
            if (MainViewModel.state == WindowState.Normal)
            {
                delegateState?.Invoke(WindowState.Minimized);
            }
        }
    }
}