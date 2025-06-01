using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string _name;
        private int _stableXP;
        private int _stableLevel;
        private int _gold;

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }
        public int StableXP
        {
            get { return _stableXP; }
            set { _stableXP = value; OnPropertyChanged(nameof(StableXP)); }
        }
        public int StableLevel
        {
            get { return _stableLevel; }
            set { _stableLevel = value; OnPropertyChanged(nameof(StableLevel)); }
        }
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; OnPropertyChanged(nameof(Gold)); }
        }
        public ObservableCollection<GameItem> Inventory { get; set; }
        public ObservableCollection<QuestStatus> Quests { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
            Quests = new ObservableCollection<QuestStatus>();
        }
    }
}