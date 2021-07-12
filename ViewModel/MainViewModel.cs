using PracticeCode.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLib;

namespace PracticeCode.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.commandDragMove = new DelegateCommand(DragMove);
            this.commandClick = new DelegateCommand(Click);
            //class1.Print();
        }

        public static TitleViewModel titleViewModel { get; set; } = null;
        public static ResultContentViewModel resultContentViewModel { get; set; } = null;
        public static MenuBarViewModel menuBarViewModel { get; set; } = null;
        public static SelectedButtonViewModel selectedButtonViewModel { get; set; } = null;

        //private Class1 class1 = new Class1();
        private DelegateCommand commandDragMove = null;
        private DelegateCommand commandClick = null;

        public DelegateCommand CommandDragMove
        {
            get => this.commandDragMove;
            set => this.commandDragMove = value;
        }

        public DelegateCommand CommandClick
        {
            get => this.commandClick;
            set => this.commandClick = value;
        }

        private void DragMove(object obj)
        {
            MainWindow mainWindow = obj as MainWindow; // obj as MainWindow ?
            mainWindow.DragMove();
        }

        private void Click(object obj) // Click Event
        {
            Console.WriteLine("Main");
            string type = obj as string; // obj as string
            if (type == "Test") // MainWindow.xmal 버튼에서 선언한 CommandParameter?
            {
                if (string.IsNullOrEmpty(titleViewModel.Text) == false) // titleViewModel이 null이 아니면
                    titleViewModel.Text = "";
                else
                    titleViewModel.Text = "계산기";
            }
        }
    }
}
