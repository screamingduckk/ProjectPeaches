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
        private int _idnum;



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

        public int IdNum
        {
            get { return _idnum; }
            set { _idnum = value; OnPropertyChanged(nameof(IdNum)); }
        }

        public ObservableCollection<GameItem> HorseInventory { get; set; }

        private static List<Horse> _ownedHorses = new List<Horse>();

        internal void AddHorse(string barnName, string formalName, int age, string gender, int horseXP, int horseLevel, string imageName, int IDnum)
        {
            Horse horse = new Horse();
            horse.BarnName = barnName;
            horse.FormalName = formalName;
            horse.Age = age;
            horse.GenderId = gender;
            horse.HorseXP = horseXP;
            horse.HorseLevel = horseLevel;
            horse.ImageName = imageName;
            horse.IdNum = IDnum;
           
            _ownedHorses.Add(horse);

        }

        public Horse GetHorse(int horseID)
        {
            foreach (Horse horse in _ownedHorses)
            { if (horse.IdNum == horseID) { return horse; } }

            return null;

        }
    }


}