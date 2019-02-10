using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items
{
    class PotionClass : ItemClass //derived from item class (implements item class)
    {
        //constructor
        public PotionClass()
        {
            Name = "A healing potion";
            Weight = 1;
        } 
    }
}
