class Dice
{
    public int Sides { get; set; }
    public int Roll()
    {
        Random random = new Random();
        return  random.Next(1, this.Sides+1);
    }
    public Dice()
    {
        this.Sides = 6;
    }
    public Dice(int sides)
    {
        this.Sides = sides;
    }
}

class Program
{
    public  static void Main()
    {
        Dice diceD6 = new Dice();
        Dice diceD8 = new Dice(8);
        diceD6.Roll();
        Console.WriteLine(diceD6.Sides);
        Console.WriteLine(diceD8.Sides);
    }
}