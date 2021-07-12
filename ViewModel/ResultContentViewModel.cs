using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.ViewModel
{
    public class ResultContentViewModel : Notifier
    {
        public ResultContentViewModel()
        {
            MainViewModel.resultContentViewModel = this;
        }

        private string text = "0";
        public string Text
        {
            get { return this.text; }
            set { this.text = value; Notify("Text"); }
        }
    }
}
