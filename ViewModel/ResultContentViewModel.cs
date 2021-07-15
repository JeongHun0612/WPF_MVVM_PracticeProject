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
            //MainViewModel.resultContentViewModel = this;
        }

        private string resultContent = "0";
        private string resultPreviewContent = null;
        public string ResultContent
        {
            get { return this.resultContent; }
            set { this.resultContent = value; Notify("ResultContent"); }
        }

        public string ResultPreviewContent
        {
            get { return this.resultPreviewContent; }
            set { this.resultPreviewContent = value; Notify("ResultPreviewContent"); }
        }
    }
}
