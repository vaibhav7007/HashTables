using System;

namespace DataStructure_HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hash Table Programs");
            Console.WriteLine("Please choose below option want to execute");
            Console.WriteLine("1.Frequency of Sentence\n2.Frequency of paragraph");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    string sentence = "To be or not to be";
                    CountNumbOfOccurence(sentence);
                    break;
                case 2:
                    string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    CountNumbOfOccurence(para);
                    break;
            }
            Console.ReadLine();
        }

        public static void CountNumbOfOccurence(string paragraph)
        {
            MyMapNode<string, int> hashtable = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');

            foreach (string word in words)
            {
                if (hashtable.Exists(word.ToLower()))
                {
                    hashtable.Add(word.ToLower(), hashtable.Get(word.ToLower()) + 1);
                }
                else
                {
                    hashtable.Add(word.ToLower(), 1);
                }
            }
            Console.WriteLine("The frequency of words will be:");
            hashtable.Display();
        }
    }
}