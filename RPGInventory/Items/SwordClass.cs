using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Items
{
    class SwordClass : ItemClass //derived from item class (implements item class)
    {
        //constructor
        public SwordClass()
        {
            Name = "A wooden sword";
            Weight = 3;
        }
    }
}
