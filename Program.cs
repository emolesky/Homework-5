namespace AnimalsAndSounds
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cat aCat1 = new Cat();
            Cat aCat2 = new Cat();

            Dog aDog1 = new Dog();  
            Dog aDog2 = new Dog();

            Console.WriteLine(aCat1);
            Console.WriteLine(aCat2);
            Console.WriteLine(aDog1);
            Console.WriteLine(aDog2);
        }
    }
}
