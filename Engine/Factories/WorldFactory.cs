using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld() 
        {  
            World newWorld = new World();
            newWorld.AddLocation(0, "Stable", "A cosy little stable.", 
                "C:\\Users\\isabe\\source\\repos\\ProjectPeaches\\Engine\\Images\\Locations\\stable.jpg");
            newWorld.AddLocation(1, "Shop", "The local tack shop.", 
                "C:\\Users\\isabe\\source\\repos\\ProjectPeaches\\Engine\\Images\\Locations\\shop.jpg");
            newWorld.AddLocation(2, "Arena", "A big arena for training.",
                "C:\\Users\\isabe\\source\\repos\\ProjectPeaches\\Engine\\Images\\Locations\\arena.jpg");
            newWorld.LocationAt(2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(01));
            newWorld.AddLocation(3, "Race Track", "The local racetrack.", 
                "C:\\Users\\isabe\\source\\repos\\ProjectPeaches\\Engine\\Images\\Locations\\racetrack.jpg");
            newWorld.AddLocation(4, "Vet", "The vet clinic.", 
                "C:\\Users\\isabe\\source\\repos\\ProjectPeaches\\Engine\\Images\\Locations\\vet.jpg");
            
            return newWorld; 
        
        }
    }
}
