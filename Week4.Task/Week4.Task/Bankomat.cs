using System;
namespace Week4.Task
{
    partial class Program
    {
        public static class Bankomat
        {

          public static void Output(int[] bankNotes, int input)
            {
                for (int i = 0; i < bankNotes.Length; i++)
                {
                    if (input >= bankNotes[i])
                    {
                        int bankNotesCount = input / bankNotes[i];
                        input -= bankNotesCount * bankNotes[i];
                        Console.WriteLine(bankNotesCount + " eded - " + bankNotes[i] + " AZN");
                    }
                }
            }

          public static bool Validation(string input)
            {
                return (string.IsNullOrEmpty(Convert.ToString(input)) || string.IsNullOrWhiteSpace(Convert.ToString(input))) || !Int32.TryParse(input, out int money);
            }
        }
    }
    }

