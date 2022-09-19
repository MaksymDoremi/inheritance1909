namespace Inheritance1909;

public class Program
{
    public static void Main(string[] args)
    {
        Human human = new Human("Karel", 10);
        Console.WriteLine("Human says " + human.question());

        Human politik = new Politik("Politickej", 34, "spd");
        Console.WriteLine("Politik says " + politik.question());

        Human svetec = new Svetec("Svetecky", 12, 66);
        Console.WriteLine("Svetec says " + svetec.question());



    }
}