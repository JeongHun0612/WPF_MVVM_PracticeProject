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
    }
}
