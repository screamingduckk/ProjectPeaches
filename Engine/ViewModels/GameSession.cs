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
        private Horse _selectedHorse;

        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Horse SelectedHorse 
        { 
            get { return _selectedHorse; }
            set 
            { 
                _selectedHorse = value; 
                OnPropertyChanged(nameof(SelectedHorse)); 
            }
        }
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

            
            CurrentWorld = WorldFactory.CreateWorld();
            HorseFactory.CreateHorse();
            CurrentLocation = CurrentWorld.LocationAt(0);
            SelectedHorse = Horse.OwnedHorses.FirstOrDefault(); // Default to the first horse



        }

        public List<Horse> _displayOwnedHorses
        {
            get { return Horse.OwnedHorses; }
        }

        public void OnClick_setLocID(int locID)
        {
            CurrentLocation = CurrentWorld.LocationAt(locID);
        }

        public void OnClick_setHorseID(int IDnum)
        {
            SelectedHorse = _selectedHorse.GetHorseByID(IDnum);
        }

        private void GivePlayerQuestsAtLocation()
        {
            foreach (Quest quest in CurrentLocation.QuestsAvailableHere)
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID))
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));
                }
            }
        }

    }
}
