using System;
using System.Text.Encodings.Web;

namespace project {
    
    class Program {
        
        static void Main() {
            
            // cw + enter = System.Console.WriteLine()

            // Math.Abs = Intoarce numarul in pozitiv:
            System.Console.WriteLine(Math.Abs(-20));
            // Math.Ceiling = Rotungeste numerele inspre pozitiv:
            System.Console.WriteLine(Math.Ceiling(4.11f));
            // Math.Floor = Rotungeste numerege inspre negative:
            System.Console.WriteLine(Math.Floor(4.99f));
            
            // Mart.Round = Rotungeste numerele independenta de nr:
            System.Console.WriteLine(Math.Round(4.56f));
            // Math.Min = Afla cel mai mic nr din doua nr:
            System.Console.WriteLine(Math.Min(5, 0));
            // Math.Max = Afla cel mai mare nr din doua nr:
            System.Console.WriteLine(Math.Max(5, 0));
            // Math.Pow = Scoate numerele in grade
            System.Console.WriteLine(Math.Pow(5, 2));

            System.Console.WriteLine("Inscrieti raza cercului: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            System.Console.WriteLine("Aria cercului cu raza {0} este egala ci {1}", radius, area);
        }
        
    }

}