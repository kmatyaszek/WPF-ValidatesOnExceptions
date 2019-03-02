using Prism.Mvvm;
using System;
using System.Threading.Tasks;

namespace WpfValidationException
{
    public class MainViewModel : BindableBase
    {
        private string _name;
        private string _description;

        public async Task LoadAsync()
        {
            //TODO: retrieve data from data service
            Name = "TestName";
            Description = "TestDescription";
        }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty!");

                _name = value;
                RaisePropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Description cannot be empty!");

                _description = value;
                RaisePropertyChanged();
            }
        }
    }
}