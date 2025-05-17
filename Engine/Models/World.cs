using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();
        internal void AddLocation(int locID, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.LocID = locID;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;
            _locations.Add(loc);

        }

        public Location LocationAt(int locID) 
        { 
            foreach (Location loc in _locations) 
                { if (loc.LocID == locID) { return loc; } }
           
            return null;

        }

    }
}
