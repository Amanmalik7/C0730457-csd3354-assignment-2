using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730457_csd3354_assignment_2
{


    namespace DelegatesAndEvents
    {
        public class DelegateExercises
        {
            public delegate void MyDelegate();
            void Method1(int i)
            {
                Console.WriteLine("Method1");
                Console.ReadLine();
            }
            public void Method2()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                myDelegate();
            }

        }
        namespace DelegatesAndEvents
        {
            class Program
            {
                static void Main(string[] args)
                {
                    DelegateExercises delegateExercises = new DelegateExercises();
                    delegateExercises.Method2();
                }
            }
        }

    






