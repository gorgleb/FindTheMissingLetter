using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            char[] array = new char[] { 'a', 'b', 'c', 'd', 'f' };
            Console.WriteLine(Kata.FindMissingLetter(array));

        }


    }
        public class Kata
        {
            public static char FindMissingLetter(char[] array)
            {
      
                char MissingLetter =' ' ;
                int FirstOccurrenceIndex = 0;  
                char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                char[] _alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        
                if (array[0].ToString() != array[0].ToString().ToUpper())
                {
                    for (int j = 0; j < _alpha.Length; j++)
                    {
                        if (array[0] == _alpha[j])
                        {
                            FirstOccurrenceIndex = j;
                        }
                    }
                    for (int i = 0; i < _alpha.Length; i++)
                    {
                        if (array[i] != _alpha[FirstOccurrenceIndex + i])
                        {
                            MissingLetter = _alpha[FirstOccurrenceIndex + i];
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < alpha.Length; j++)
                    {
                        if (array[0] == alpha[j])
                        {
                            FirstOccurrenceIndex = j;
                        Console.WriteLine(FirstOccurrenceIndex);
                        }
                    }
                    for (int i = 0; i < alpha.Length; i++)
                    {
                        if (array[i] != alpha[FirstOccurrenceIndex + i])
                        {
                            MissingLetter = alpha[FirstOccurrenceIndex + i];
                            break;
                        }
                    }
                }
      
                return MissingLetter;
            }
        }
}
    