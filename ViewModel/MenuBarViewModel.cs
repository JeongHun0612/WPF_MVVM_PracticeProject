using PracticeCode.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PracticeCode.ViewModel
{
    public class MenuBarViewModel : Notifier
    {
        public MenuBarViewModel()
        {

            this.commandNavOpenClick = new DelegateCommand(NavOpenClick);
            this.commandNavCloseClick = new DelegateCommand(NavCloseClick);
            this.commandListBoxSelection = new DelegateCommand(ListBoxSelection);
            this.listItem.Add("표준 계산기");
            this.listItem.Add("공학용 계산기");
            this.listItem.Add("프로그래머 계산기");
        }

        private DelegateCommand commandNavOpenClick = null;
        private DelegateCommand commandNavCloseClick = null;
        private DelegateCommand commandListBoxSelection = null;

        private List<string> listItem = new List<string>();

        public List<string> ListItem
        {
            get => this.listItem;
            set => this.listItem = value;
        }

        public DelegateCommand CommandNavOpenClick
        {
            get => this.commandNavOpenClick;
            set => this.commandNavOpenClick = value;
        }
        public DelegateCommand CommandNavCloseClick
        {
            get => this.commandNavCloseClick;
            set => this.commandNavCloseClick = value;
        }
        public DelegateCommand CommandListBoxSelection
        {
            get => this.commandListBoxSelection;
            set => this.commandListBoxSelection = value;
        }
        private void NavOpenClick(object obj)
        {
            MainViewModel.selectedButtonViewModel.IsEnabled = false;
        }
        private void NavCloseClick(object obj)
        {
            MainViewModel.selectedButtonViewModel.IsEnabled = true;
        }
        private void ListBoxSelection(object obj)
        {
            if (obj == null)
            {
                return;
            }
            string selectedName = obj as string;

            MainViewModel.titleViewModel.Text = selectedName;
        }
    }
}
