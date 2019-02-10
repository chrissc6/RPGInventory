using RPGInventory.Items; //added using statement 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGInventory.Containers
{
    class BagClass : ItemClass
    {
        protected int _capacity;
        protected ItemClass[] _itemsInBag;
        protected int _currentIndex;

        public virtual void AddItem(ItemClass itemToAdd)
        {
            if(_currentIndex >= _capacity)
            {
                Console.WriteLine("The bag is full!"); //check if bag is full
            }
            else
            {
                _itemsInBag[_currentIndex] = itemToAdd;
                _currentIndex++; //so next item goes into index
            }
        }

        public virtual ItemClass RemoveItem()
        {
            if(_currentIndex == 0)
            {
                Console.WriteLine("The bag is empty");
                return null;
            }
            else
            {
                ItemClass itemToReturn = _itemsInBag[_currentIndex-1];
                _itemsInBag[_currentIndex-1] = null; //because were removing it
                _currentIndex--;
                return itemToReturn;
            } 
        }

        public virtual void DisplayContents()
        {
            Console.WriteLine("Items in bag");
            foreach (var i in _itemsInBag)
            {
                if(i != null)
                {
                    Console.WriteLine(i.Name);
                }
            }
        }

        //constructor
        public BagClass(int capacity)
        {
            Name = "A small bag";
            Weight = 2;
            _itemsInBag = new ItemClass[capacity];
            _capacity = capacity;
        }
    }
}
