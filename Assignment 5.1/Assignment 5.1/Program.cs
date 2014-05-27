using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._1
{
    class Program
  {
    static void Main(string[] args)
    {
      DayTimeStudent personA = new DayTimeStudent(1, "Bob Smith", "780-421-1234", "S18", "HP2298");
            EveningStudent personB = new EveningStudent(2, "Jane Doe", "780-773-7763", "WB102", "C#");
            personA.DisplayStudent();
            personB.DisplayStudent();
    }
  }
}

 
 


        
        
        
       