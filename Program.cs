using System;

namespace projects{
    class Program{

        static void Main()
        {
            double[] masfactor;
            System.Console.Write("Enter the numbers that splits probelom:   ");
            var input=(string?)null;
            input= Console.ReadLine();
            
          

          string[] words = input.Split(new char[]{' '});
            masfactor = new double[words.Length];
            int count=0;
            foreach(string s in words){
                
                
                masfactor[count] = Convert.ToDouble(s);               
                count++;
            }
           
        factorial(masfactor);

        }
        
         public static void factorial(double[] mas){
              foreach(double a in mas){
               double num=a;
               
               double fact=1;
                if(num>1&num%1==0){
                for(double j=num;j>1;j--){

                   
                        fact=num*fact;
                        num--;
                     
                     }
                     System.Console.WriteLine(" Факториал равен "+fact);
                }else System.Console.WriteLine("    отрицательное число или дробное число ");
                    
            }  
            }

        public static void factors(int[] x){
            
            foreach(int a in x){
               int num=a;
               
               System.Console.Write("Число "+num); 
               int fact=1;
                if(num>1){
                for(int j=num;j>1;j--){

                   
                        fact=num*fact;
                        num--;
                     
                     }
                     System.Console.WriteLine(" Факториал равен "+fact);
                }else System.Console.WriteLine("    отрицательное число");
                    
            }


        }
        
    }

}
