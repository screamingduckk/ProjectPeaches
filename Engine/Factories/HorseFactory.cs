using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal class HorseFactory
    {
        

        internal static  Horse CreateHorse()
        {
            Horse newHorse = new Horse();

            newHorse.AddHorse("Thunder", "Thunder", 5, "Gelding", 26, 3, 
                "C:\\Users\\isabe\\Source\\Repos\\ProjectPeaches\\Engine\\Images\\Horses\\thunder.jpg", 01);
            newHorse.AddHorse("Brandy", "Cool Cat", 5, "Mare", 2, 1, 
                "C:\\Users\\isabe\\Source\\Repos\\ProjectPeaches\\Engine\\Images\\Horses\\horse1.jpg", 02);
            newHorse.AddHorse("Fluffy", "The Axe Murderer", 7, "Stallion", 50, 4, 
                "C:\\Users\\isabe\\Source\\Repos\\ProjectPeaches\\Engine\\Images\\Horses\\fluffy.jpg", 03);
        
            
            return newHorse;

        }



    }
}
