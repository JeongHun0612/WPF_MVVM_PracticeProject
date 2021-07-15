using PracticeCode.ViewModel;

namespace PracticeCode.Model
{
    public class TestModel : NotifierCollection
    {
        public TestModel(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        private string name = string.Empty;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; NotifyCollection("Name"); }
        }

        private string description = string.Empty;
        public string Description
        {
            get { return this.description; }
            set { this.description = value; NotifyCollection("Description"); }
        }
    }
}
