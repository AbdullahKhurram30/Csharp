//var cat = new Animal("Cat"); //new Something; its basically malloc; and as discussed it does more than malloc
var cat = new Cat();
var dog = new Animal("Dog");

dog.Eat();
cat.Speak();

class Animal
{
    public string Type = ""; //everything is private until made public (or protected)

    Animal() {} //this constructor default constructor, if not defined its "implicit", but we defined it explicitly and made it private
    // meaning we cannt access it outside the class

    public Animal(string type)      //this constructor is public, the above + this; we basically are enforcing that we need type if you want
    {                               //to create a instance of this class
        this.Type = type;   //notice this.; this is special keyword/reference; when we declare an object of this class; this will refer to itself
    }                       //we dont need to use this. but its good practice; so you know from where "Type" is coming

    public void Speak()
    {
        Console.WriteLine("{0} is speaking", this.Type);
    }

    protected void FindFood()
    {
        Console.WriteLine($"{this.Type} is finding food");
    }
    
    public void Eat()
    {
        this.FindFood();
        Console.WriteLine($"{this.Type} is eating");
    }
}

class Cat : Animal
{
    public string Name { get; private set; }

    public Cat() : base("Cat")
    {
        this.Name = "Stray cat";
    }

    public Cat(string name) : base("Cat")
    {
        this.Name = name;
    }

    public void Speak()
    {
        Console.WriteLine(this.Name + " is meowing");
        base.FindFood();
    }
}