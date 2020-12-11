using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAANG_Interview
{
    class QuestionOne
    {
        // Brute Force Solution
        public static void solveQuestionOne(int[] array, int target)
        {
            //if (array == null || target == null)
            //{
            //    Console.WriteLine("Undefined parameter - No Solution");
            //    return;
            //}
            if (array.Length == 0)
            {
                Console.WriteLine("Empty Array - No Solution");
                return;
            }

            
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target)
                    {
                        Console.WriteLine("Solution: \n" 
                            + "Index 1: " + i + "\n" + "Value 1: " + array[i] + "\n" 
                            + "Index 2: " + j + "\n" + "Value 2: " + array[j]);
                        return;
                    }
                }
            }
        }
    }
}
