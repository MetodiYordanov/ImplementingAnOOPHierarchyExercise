using System.Collections.Generic;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _orderHistory = new();
        private string _name;
        private string _email;

        public Customer(string name, string email)
        {
            this.Name = name;
            this.Email = email;
        }

        public string Name 
        { 
            get
            { 
                return this._name; 
            }
            private set
            {
                this._name = value;
            }
        }

        public string Email 
        { 
            get
            {  
                return this._email;
            }
            private set
            {
                this._email = value;
            }
        }

        public IReadOnlyCollection<Order> OrderHistory 
        { 
            get
            {
                return this._orderHistory.AsReadOnly();
            }
        }

        public void AddOrder(Order order)
        {
            this._orderHistory.Add(order);
        }
    }
}
