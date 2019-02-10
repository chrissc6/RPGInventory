using RPGInventory.Containers;
using RPGInventory.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            //BagTest();

            //SackTest();

            RemoveTest();
        }

        private static void RemoveTest()
        {
            BagClass myBag = new BagClass(3);

            var item1 = new SwordClass();
            var item2 = new PotionClass();
            var item3 = new PotionClass();

            myBag.AddItem(item1);
            myBag.AddItem(item2);
            myBag.AddItem(item3);

            myBag.DisplayContents();

            var remove = myBag.RemoveItem();
            Console.WriteLine($"Remove {item3.Name} from bag");

            myBag.DisplayContents();

        }

        private static void BagTest()
        {
            BagClass myBag = new BagClass(3);

            var item1 = new SwordClass();
            var item2 = new PotionClass();

            myBag.AddItem(item1);
            myBag.AddItem(item2);

            myBag.DisplayContents();
        }

        private static void SackTest()
        {
            SackClass mysack = new SackClass(4);

            var item1 = new PotionClass();
           
            mysack.AddItem(item1);

            mysack.DisplayContents();
        }
    }
}
