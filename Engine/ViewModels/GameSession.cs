using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {

        private Location _currentLocation;

        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Horse SelectedHorse { get; set; }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; OnPropertyChanged("CurrentLocation");
                GivePlayerQuestsAtLocation();
            }
        }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                Name = "PlayerName",
                StableXP = 0,
                StableLevel = 1,
                Gold = 500
            };


            SelectedHorse = new Horse
            ("Brandy", "Cool Cat", 5, "Mare", 0, 1, "horse1.png")
            {
            };


            CurrentWorld = WorldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0);



        }

        public void OnClick_setLocID(int locID)
        {
            CurrentLocation = CurrentWorld.LocationAt(locID);
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach(Quest quest in CurrentLocation.QuestsAvailableHere)
            {
               if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }

    }
}
