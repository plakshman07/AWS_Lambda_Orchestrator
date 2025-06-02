namespace SayHelloFunction
{
    public class SayHelloHandler
    {
        public string Handle(string name)
        {
            Console.WriteLine($"Saying hello to {name}");
            return $"Hello {name}!";
        }
    }
}
