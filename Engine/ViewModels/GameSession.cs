using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Horse SelectedHorse { get; set; }

        public Location CurrentLocation { get; set; }

        public GameSession() 
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "PlayerName";
            CurrentPlayer.StableXP = 0;
            CurrentPlayer.StableLevel = 1;
            CurrentPlayer.Gold = 500;

            SelectedHorse = new Horse();
            SelectedHorse.BarnName = "HorseName";
            SelectedHorse.FormalName = "FormalName";
            SelectedHorse.GenderId = "genderId";
            SelectedHorse.Age = 5;
            SelectedHorse.HorseLevel = 1;
            SelectedHorse.HorseXP = 0;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Stable";
            CurrentLocation.Description = "A cosy little stable.";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/istockphoto-1475503557-612x612.jpg";



        }
    }
}
