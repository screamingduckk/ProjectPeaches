using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class ItemFactory
    {

        private static List<GameItem> _standardGameItems;

        static ItemFactory()
        {
            _standardGameItems = new List<GameItem>();
            _standardGameItems.Add(new Tack(101, "Saddle", 10, 01));
            _standardGameItems.Add(new Tack(102, "Bridle", 5, 01));
            _standardGameItems.Add(new GameItem(201, "Apple", 1));
            _standardGameItems.Add(new GameItem(202, "Carrot", 1));

        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeId == itemTypeID);
            if (standardItem != null) 
            {
                return standardItem.Clone();
            }
            return null;
        }
    }


}
