using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ItemTypeId { get; set; }
        public int Quantity { get; set; }
        public ItemQuantity(int itemTypeId, int quantity)
        {
            ItemTypeId = itemTypeId;
            Quantity = quantity;
        }
    }
}
