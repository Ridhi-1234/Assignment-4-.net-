using System; 
using MainEmployee;
 namespace MainProgram{ 
    class Program{ 
        public static void Main(string[] args)
        { 
            PermanentEmployee e1 = new PermanentEmployee("Mansha","Mattoo","23-0879","01-03-21",55000.0,23000,1000,14000); 
            Console.WriteLine($"Information about First Employee:\n{e1}");             e1.GiveRaise(10.0); 
            Console.WriteLine($"Information about First Employee after 10% raise:\n{e1}"); 
            PermanentEmployee e2 = new 
PermanentEmployee("Astha","Kaul","23-08-79","01-0321",45000.0,21000,1200,12000); 
            Console.WriteLine($"Inforamtion about second Employee:\n{e2}");             e2.GiveRaise(10.0); 
            Console.WriteLine($"Inforamtion about second Employee after raise:\n{e2}"); 
        } 
    } 
} 

