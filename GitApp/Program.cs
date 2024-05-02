namespace GitApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Department department= new Department();
            
            Doctor doctor = new Doctor();
            doctor.Id = 1;
            department.Doctors.Add(doctor);
        }
    }
}
