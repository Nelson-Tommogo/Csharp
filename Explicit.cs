using System;
namespace typecastexplicit{
    public class Explicit{
        public static void Main(){
            double AdvancedAppli = 89.99999999999999999999999999;
            int AppliProgramming = (int) AdvancedAppli;
            Console.WriteLine(AdvancedAppli);
            Console.WriteLine(AppliProgramming);
        }
    }
}
//narrowing conversion, is a conversion that requires an explicit instruction from the programmer.
