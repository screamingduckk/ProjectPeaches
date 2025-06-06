﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity> { };
            List<ItemQuantity> rewardItems = new List<ItemQuantity> { };

            _quests.Add(new Quest(01, "Go For a Ride", "Take your horse for a ride around the farm.", itemsToComplete, 25, 10, rewardItems));
        }
    internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
