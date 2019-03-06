using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730457_csd3354_assignment_2
{


    namespace DelegatesAndEvents
    {
        public class Program
        {
            public static void Main()
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
            }
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate();

            void Method1()
            {
                System.Console.WriteLine("MyDelegate");
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }
        }
    }
}











