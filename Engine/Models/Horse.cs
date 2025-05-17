using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Horse : INotifyPropertyChanged
    {
        private string _barnName;
        private string _formalName;
        private int _age;
        private string _gender;
        private int _horseXP;
        private int _horseLevel;

        public string BarnName
        {
            get { return _barnName; }
            set { _barnName = value; OnPropertyChanged("BarnName"); }
        }
        public string FormalName { 
            get { return _formalName; }
            set { _formalName = value; OnPropertyChanged("FormalName"); }
        }
        public int Age { 
            get { return _age; } 
            set {  _age = value; OnPropertyChanged("Age"); } 
        }
        public string GenderId { 
            get { return _gender; }
            set { _gender = value; OnPropertyChanged("GenderID"); }
        }
        public int HorseXP { 
            get { return _horseXP; }
            set { _horseXP = value; OnPropertyChanged("HorseXP"); } 
        }
        public int HorseLevel { 
            get { return _horseLevel; }
            set {_horseLevel = value; OnPropertyChanged("HorseLevel"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
