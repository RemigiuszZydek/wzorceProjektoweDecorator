using System;

interface ICoffee
{
    double Cost();
}

class BasicCoffee : ICoffee
{
    public double Cost()
    {
        return 2.0;
    }
}

abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual double Cost()
    {
        return coffee.Cost();
    }
}
class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override double Cost()
    {
        return base.Cost() + 0.5;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        ICoffee basicCoffee = new BasicCoffee();
        Console.WriteLine("Kawa bez dodatków: " + basicCoffee.Cost());

        
        ICoffee coffeeWithMilk = new MilkDecorator(new BasicCoffee());
        Console.WriteLine("Kawa z mlekiem: " + coffeeWithMilk.Cost());
    }
}
