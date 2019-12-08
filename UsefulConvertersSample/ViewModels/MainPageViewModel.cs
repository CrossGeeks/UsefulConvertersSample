using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UsefulConvertersSample.ViewModels
{
    public class MainPageViewModel: INotifyPropertyChanged
    {
        double amount;
        public double Amount
        {
            set
            {
                if (amount != value)
                {
                    amount = value;
                    OnPropertyChanged("Amount");
                }
            }
            get
            {
                return amount;
            }
        }
        public double FullValAmount { get; set; } = 23.335;
        public DateTime Date { get; set; } = DateTime.Now.AddDays(-1);
        public string UserName { get; set; } = "John";
        public string Email { get; set; }
        public List<string> Items { get; set; } = new List<string>() { "hello"};


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
