using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Tack : GameItem
    {

        public int SkillBonus { get; set; }

        public Tack (int itemTypeID, string name, int price, int skillBonus) : base(itemTypeID, name, price)
        {
            SkillBonus = skillBonus;
        }

        public new Tack Clone()
        {
            return new Tack(ItemTypeId, Name, Price, SkillBonus);
        }
    }
}
