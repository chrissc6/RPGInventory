using RPGInventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Containers
{
    class SackClass : BagClass
    {
        public override void AddItem(ItemClass itemToAdd)
        {
            if (itemToAdd.Weight > 1)
            {
                Console.WriteLine("Item too big for the sack");
            }
            else
            {
                base.AddItem(itemToAdd);
            }

        }

        //constructor
        public SackClass(int capacity) : base(capacity) //chaining constructors
        {

        }
    }
}
