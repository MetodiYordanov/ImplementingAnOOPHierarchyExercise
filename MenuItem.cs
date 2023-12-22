namespace ExerciseOopHierarchy;

public abstract class MenuItem
{
    private string _name;
    private string _description;
    private decimal _price;

    public MenuItem(string name, string description, decimal price)
    {
        this.Name = name;
        this.Description = description;
        this.Price = price;
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

    public string Description
    {
        get
        {
            return this._description;
        }
        private set
        {
            this._description = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this._price;
        }
        private set
        {
            this._price = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Description} - ${this.Price:F2}";
    }
}
