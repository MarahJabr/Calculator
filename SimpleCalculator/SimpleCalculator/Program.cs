using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = Program.add("//[;][***]\n1;1002***3");

           Console.WriteLine(result);
            
            }

        public static int add(String data){
            int sum = 0;
            String[] newArray;
            String output;
            String delimitersString;
            String[] delimitersArray;
           String[] delimiters=new String[] { ",", "\n" }; 
            int flag=0;
            if (data == "") return sum;
            else
            {
                if (data.StartsWith("//"))
                {
                    flag = data.IndexOf("\n");
                    delimitersString = data.Substring(0, flag + 1);
                    delimitersArray = delimitersString.Split(new String[] { "//", "\n" }, StringSplitOptions.None);
                    delimiters = delimitersArray[1].Split(new String[] { "[", "]" }, StringSplitOptions.None);
                    output = data.Substring(flag + 1);
                  
                }
                else
                {
                    output = data;
                }
                newArray = output.Split(delimiters, StringSplitOptions.None);
            
            }
          
          int temp;
           for(int j=0; j< 3;j++)
            {
                if (j >= newArray.Count()) break;
             
               try
               {
                  temp= Convert.ToInt32(newArray[j]);
                  if (temp < 0) throw new NegativeNumberException("negative number");
                  else if (temp > 1000) continue;
                   sum += temp;
               }
               catch (FormatException e)
               {
                   Console.WriteLine("Input string is not a sequence of digits.");
               }
               catch (OverflowException e)
               {
                   Console.WriteLine("The number cannot fit in an Int32.");
               }
              
            }
         
            return sum;
        }
    }
}
