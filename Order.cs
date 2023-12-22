using System.Collections.Generic;
using System.Linq;

namespace ExerciseOopHierarchy
{
    public class Order
    {
        private List<MenuItem> _items = new();

        public IReadOnlyCollection<MenuItem> Items 
        {
            get 
            {
                return this._items.AsReadOnly();
            }
        }

        public void AddItem(MenuItem item)
        {
            this._items.Add(item);
        }

        public decimal GetTotal()
        {
            decimal result = this._items.Sum(item => item.Price);
            //return this._items.Select(i => i.Price).Sum()

            return result;
        }
    }
}
