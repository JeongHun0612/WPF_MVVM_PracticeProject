using PracticeCode.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode.Model
{
    public class ListModel : NotifierCollection
    {
        public ListModel(string name)
        {
            this.name = name;
        }

        private string name = string.Empty;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; NotifyCollection("Name"); }
        }
    }
}
