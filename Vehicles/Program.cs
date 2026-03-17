namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car car1 = new Car("Toyota", "Corolla");
            Car car2 = new Car("BMW", "M3");
            Motorcycle bike1 = new Motorcycle("Ducati", "Z", false);
            Motorcycle bike2 = new Motorcycle("Honda", "R1", true);
            //car1.Drive();
            //bike1.Drive();
            car1.StartEngine();
            car2.StartEngine();
            bike1.StartEngine();
            bike2.StartEngine();

            car1.Drive();
            car2.Drive();
            bike1.Drive();
            bike2.Drive();
        }
    }
}
