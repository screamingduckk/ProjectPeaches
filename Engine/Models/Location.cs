﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Location
    {

        public string Name {  get; set; }
        public string Description {  get; set; }
        public string ImageName {  get; set; } 
        public int LocID { get; set; }

        public List<Quest>QuestsAvailableHere {get; set; } = new List<Quest>();



    }
}
