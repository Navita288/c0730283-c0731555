using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730283___c0731555



{
    public class DelegateExercises
    {
        //student name navita navita
        //studentname gagandeep sidhu
        public delegate void MyDelegate(int intValue);
        public Method1(int intMethod1)
            {
          return intMethod1*2;
            }  
         public Method1(int intMethod2)
            {
          return intMethod2*10;
            }
          public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            int result1 = myDelegate(10);
            System.Console.WriteLine(result1);
            MyDelegate myDelegate = new MyDelegate(Method2);
            int result2 = myDelegate(10);
            System.Console.WriteLine(result2);
            
        }
       

    }
}
