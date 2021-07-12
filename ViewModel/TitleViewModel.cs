using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.ViewModel
{
    public class TitleViewModel : Notifier
    {
        public TitleViewModel()
        {
            MainViewModel.titleViewModel = this;
        }

        private string text = "계산기";
        public string Text
        {
            get { return this.text; }
            set { this.text = value; Notify("Text"); }
        }
    }
}