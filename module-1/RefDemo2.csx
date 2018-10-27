
public class MyClass
{
    int[] numList = new int[] { 1, 2, 3, 4, 5 };
    public ref int GetCurrentPrice()
    {
        return ref numList[0];
    }

    public void Run()
    {
        ref int num = ref GetCurrentPrice();
        num = 555555555;

        Console.WriteLine(String.Join(", ", numList));
    }

}

var myClass = new MyClass();
myClass.Run();