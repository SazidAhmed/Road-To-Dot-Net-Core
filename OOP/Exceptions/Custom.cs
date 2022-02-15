using System;

namespace CustomExceptions {
    class CustomExceptions{

        public static void checkNumber(int num){
            try
            {
                int[] myNumbers = {1, 2, 3};
                Console.WriteLine(myNumbers[num]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }

        public static void checkAge(int age){
            if(age < 18){
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }else{
                Console.WriteLine("Access granted");
            }
        }
    }
}