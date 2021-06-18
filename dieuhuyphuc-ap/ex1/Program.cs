using System;

namespace dieuhuyphuc_ap.ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person ps1 = new Person();
            ps1.Age = 40;
            ps1.Name = "Amar";
            Console.WriteLine("Person deatails - name = " + ps1.Name + ", Age =  " + ps1.Age);
            Console.WriteLine("Person deatails (After incrementing age)- Name = "+ps1.Name + ", Age = "+(ps1.Age+1 ));
        }
    }
} 