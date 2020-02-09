using PcBuilder.Models;

namespace PcBuilder {
    class Program {
        static void Main(string[] args) {
            System.Console.WriteLine("Build your PC today");
            
            // Użytkownik wszedł do sklepu
            User user = new User();

            Ram ram = new Ram();
            Psu psu = new Psu();
            Cpu cpu = new Cpu();

            // Chciałbym kupić komputer
            Pc newlyCreatedPc = new Pc(cpu, psu, ram);


            // Czy komputer działa?

            if (!(newlyCreatedPc.HasRequiredComponents() &&
                newlyCreatedPc.HasPostivePowerBalance())) {
                System.Console.WriteLine("Nie działa, nie sprzedajemy");
            } else {
                // Płacę za komputer!
                user.AddPc(newlyCreatedPc);
            }
        }
    }
}
