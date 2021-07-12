using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.ViewModel
{
    public class MenuBarViewModel : Notifier
    {
        public MenuBarViewModel()
        {
            MainViewModel.menuBarViewModel = this;
        }
    }
}
