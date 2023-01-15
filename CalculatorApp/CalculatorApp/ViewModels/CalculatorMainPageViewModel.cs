using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.ViewModels
{
    public class CalculatorMainPageViewModel : INotifyPropertyChanged
    {
        private string result;
        public string FinalResult
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                OnPropertyChanged("FinalResult");
            }
        }

        private string previousCalculation;
        public string WholeCalculation
        {
            get
            {
                return previousCalculation;
            }
            set
            {
                previousCalculation = value;
                OnPropertyChanged("WholeCalculation");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
