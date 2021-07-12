using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.ViewModel
{
    public class SelectedButtonViewModel
    {
        public DelegateCommand CommandClick { get; private set; }

        public SelectedButtonViewModel()
        {
            CommandClick = new DelegateCommand(Click);
        }
        public static ResultContentViewModel resultContentViewModel { get; set; } = null;
        public static TitleViewModel titleViewModel { get; set; } = null;


        private void Click(object obj) // Click Event
        {
            Console.WriteLine("Selected");
            string type = obj as string; // obj as string
            if (type == "Test") // MainWindow.xmal 버튼에서 선언한 CommandParameter?
            {
                if (string.IsNullOrEmpty(resultContentViewModel.Text) == false) // titleViewModel이 null이 아니면
                    resultContentViewModel.Text = "";
                else
                    resultContentViewModel.Text = "계산기";
            }
        }
    }
}
