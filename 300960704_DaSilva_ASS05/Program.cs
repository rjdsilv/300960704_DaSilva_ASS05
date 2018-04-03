using _300960704_DaSilva_ASS04.DataStructure;
using _300960704_DaSilva_ASS04.Exception;
using System;

namespace _300960704_DaSilva_ASS04
{
    class Program
    {
        static void Main(string[] args)
        {
            SolveQuestion(ReadQuestion());
            Console.WriteLine("\nPress ENTER key to exit...");
            Console.Read();
        }

        private static void SolveQuestion(int question)
        {
            if (question == 1)
            {
                SolveQuestionOne();
            }
            else if (question == 2)
            {
                SolveQuestionTwo();
            }
            else
            {
                throw new InvalidQuestionException(string.Format("The question {0} is not a valid question!", question));
            }
        }

        private static void SolveQuestionOne()
        {
            Console.WriteLine("Enter the text you want to be reversed: ");

            // Reads the text from input and put in the stack.
            string text = Console.ReadLine();
            Stack<char> textStack = new Stack<char>();
            foreach (char c in text)
            {
                textStack.Push(c);
            }

            // Prints the text in reverse order using the stack.
            Console.WriteLine("\n######################################################################");
            Console.Write("The text reversed is: ");
            while (!textStack.IsEmpty())
            {
                Console.Write(textStack.Pop());
            }
            Console.WriteLine("\n");
        }

        private static void SolveQuestionTwo()
        {
            Console.WriteLine("Enter a list of Integers separated by ',' and press ENTER when Finished: ");
            string[] numbersEntered = Console.ReadLine().Split(',');
            BST<int> bst = new BST<int>();

            // Reads all the numbers and put them into the BST.
            foreach (string number in numbersEntered)
            {
                if (!int.TryParse(number.Trim(), out int validNumber))
                {
                    Console.WriteLine("The list entered is either empty or contains one or more invalid numbers. Exiting the application!");
                    return;
                }

                bst.Insert(validNumber);
            }

            Console.WriteLine();
            Console.Write("Level Order: ");
            bst.LevelOrderPrint();
        }

        private static int ReadQuestion()
        {
            Console.WriteLine("What question do you want to evaluate? Choose the number between () to select!");
            Console.WriteLine("\tQuestion (1) - Reverse the text or");
            Console.Write("\tQuestion (2) - Level order traversal of binary tree: ");

            int questionNumber = 0;
            do
            {
                string valueRead = Console.ReadLine();
                if (!int.TryParse(valueRead, out questionNumber))
                {
                    Console.Write(string.Format("The option '{0}' is not valid. Choose a valid question (1) or (2): ", valueRead));
                }
                else
                {
                    if (questionNumber != 1 && questionNumber != 2)
                    {
                        Console.Write(string.Format("The option '{0}' is not valid. Choose a valid question (1) or (2): ", questionNumber));
                    }
                }
            }
            while (questionNumber != 1 && questionNumber != 2);

            return questionNumber;
        }
    }
}
