using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class NumbersArray
    {
        public int[] numbers;

        public int Numbers
        {
            get;
            set;
        }
        public NumbersArray(int size, int firstNumber, int secondNumber)
        {
            numbers = new int[size];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(firstNumber, secondNumber);
            }
            Console.WriteLine("\nArray of numbers from {0} to {1} (size {2}):", firstNumber, secondNumber, size);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < numbers.Length)
                {
                    return numbers[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < numbers.Length)
                {
                    numbers[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                } 
            }
        }

        public void FrequencyTable()
        {
            Console.WriteLine("|\tFrequency table        |");
            Console.WriteLine("--------------------------------");
            string[] arrayOfStrings = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                int occurrences = numbers.Count(x => x == number);
                arrayOfStrings[i] = $"|Number {number} is repeated {occurrences} time(s)|";
            }

            var uniqString = arrayOfStrings.Distinct();
            foreach(var item in uniqString)
            {
                Console.WriteLine(item);
            }

        }

        public void FindSubsequences()
        {
            int count = 1;
            int longestNum = numbers[0];
            int longestCount = 1;
            int firstIndex = 0;
            int lastIndex = 0;

            for (int i = 1; i < this.numbers.Length; i++)
            {
               if (numbers[i] != numbers[i - 1])
               {
                   count = 0;       
               }
                    count++;
                
                              
                if (count > longestCount)
                {
                        longestCount = count;
                        longestNum = numbers[i];
                        firstIndex = i;
                        lastIndex = i + longestCount - 1;
                }                  
                    
            }     

            for (int i = 1; i <= longestCount; i++)
            {
                if (firstIndex != lastIndex)
                {
                    Console.Write(longestNum + " ");                    
                }
                else
                {
                    Console.WriteLine("No subsequences");
                    break;
                }
            }
            Console.WriteLine();

            var numbers2 = numbers.Skip(lastIndex).ToArray();

            

            int count2 = 1;
            int longestNum2 = numbers2[0];
            int longestCount2 = 1;
            int firstIndex2 = 0;
            int lastIndex2 = 0;

            for (int i = 1; i < numbers2.Length; i++)
            {
                if (numbers2.Length == 0)
                {
                    break;
                }
                if (numbers2[i - 1] != numbers2[i])
                {
                    count2 = 0;
                }
                count2++;

                if (count2 > longestCount2)
                {
                    longestCount2 = count2;
                    longestNum2 = numbers2[i];
                    firstIndex2 = i;
                    lastIndex2 = i + longestCount2 - 1;
                }
            }

            for (int i = 1; i <= longestCount2; i++)
            {
                if (firstIndex2 != lastIndex2)
                {
                    Console.Write(longestNum2 + " ");
                }
                else
                {                   
                    break;
                }
            }
            Console.WriteLine();

        }
    }
}
