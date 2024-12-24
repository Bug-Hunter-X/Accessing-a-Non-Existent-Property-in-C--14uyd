public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a non-existent property
        Console.WriteLine(MyNonExistentProperty); 
    }
}