using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Horse : BaseNotificationClass
    {
        private string _barnName;
        private string _formalName;
        private int _age;
        private string _gender;
        private int _horseXP;
        private int _horseLevel;
        private string imageName;



        public string BarnName
        {
            get { return _barnName; }
            set { _barnName = value; OnPropertyChanged(nameof(BarnName)); }
        }
        public string FormalName
        {
            get { return _formalName; }
            set { _formalName = value; OnPropertyChanged(nameof(FormalName)); }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged(nameof(Age)); }
        }
        public string GenderId
        {
            get { return _gender; }
            set { _gender = value; OnPropertyChanged(nameof(GenderId)); }
        }
        public int HorseXP
        {
            get { return _horseXP; }
            set { _horseXP = value; OnPropertyChanged(nameof(HorseXP)); }
        }
        public int HorseLevel
        {
            get { return _horseLevel; }
            set { _horseLevel = value; OnPropertyChanged(nameof(HorseLevel)); }
        }

        public string ImageName
        {
            get { return imageName; }
            set { imageName = value; OnPropertyChanged(nameof(ImageName)); }
        }

        public ObservableCollection<GameItem> HorseInventory { get; set; }

        public Horse(string barnName, string formalName, int age, string gender, int horseXP, int horseLevel, string imageName)
        {
            BarnName = barnName;
            FormalName = formalName;
            Age = age;
            GenderId = gender;
            HorseXP = horseXP;
            HorseLevel = horseLevel;
            ImageName = string.Format("C:\\Users\\isabe\\source\\repos\\ProjectPeaches\\Engine\\Images\\Horses\\horse1.jpg", imageName);
            HorseInventory = new ObservableCollection<GameItem>();
        }
    }
}