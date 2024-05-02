namespace GitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          
            Hospital hospital = new Hospital();
               hospital.Id = 1;
            hospital.Name = "Baku Medical Plaza";

            Console.WriteLine(hospital.ToString());

            Hospital hospital2 = new Hospital();
            hospital2.Id = 2;
            hospital2.Name = "5 nomreli xestexana";

            Console.WriteLine(hospital2.ToString());

        }
    }
}
