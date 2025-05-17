using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string _name;
        private int _stableXP;
        private int _stableLevel;
        private int _gold;

        public string Name { 
            get {  return _name; } 
            set { _name = value; OnPropertyChanged("Name"); }
        }
        public int StableXP {
            get { return _stableXP; }
            set { _stableXP = value; OnPropertyChanged("StableXP"); }
                }
        public int StableLevel {
            get { return _stableLevel; } 
            set { _stableLevel = value; OnPropertyChanged("StableLevel"); } 
        }
        public int Gold {  
            get { return _gold; } 
            set { _gold = value; OnPropertyChanged("Gold"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) 
        {
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
