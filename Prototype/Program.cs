using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Prototype;

interface IPrototype
{
    Book Clone();
}
public class Book :IPrototype{

    private string title;
    private int price;

   public Book(string title, int price)
    {
        this.title=title;
        this.price=price;

    }

    

    public Book Clone()
    {
        return new Book(this.title, this.price);
    }
}




public static class program
{
    static void Main(string[] args)
    {
        var orginaled = new Book("C#",20);
        var copy =orginaled.Clone();

        

        Console.ReadLine();

    }
}