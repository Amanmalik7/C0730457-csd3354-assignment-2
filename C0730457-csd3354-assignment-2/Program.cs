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
                Console.ReadLine();
            }
        }

        public class DelegateExercises
        {
            public delegate int MyDelegate(int intValue);

            int Method1(int intMethod1)
            {
                return intMethod1 * 4;
            }

            int Method2(int intMethod1)
            {
                return intMethod1 * 20;
            }

            public void Method4(MyDelegate myDelegate)
            {
                for (int i = 1; i <= 5; i++)
                    System.Console.Write(myDelegate(i) + " ");
            }

            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                Method4(myDelegate);
                myDelegate = new MyDelegate(Method2);
                Method4(myDelegate);
            }
        }
    }
}















