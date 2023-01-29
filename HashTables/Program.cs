using System;
using System.Collections;

namespace DataStructure_HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hash Table Programs");
            Console.WriteLine("Please choose below option want to execute");
            Console.WriteLine("1.Frequency of Sentence\n2.Frequency of paragraph\n3.BST Adding Node");
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
                case 3:
                    Console.WriteLine("Welcome to the binary Search tree");
                    BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
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
            Console.WriteLine("Displaying after add operation");
            hashtable.Display();
            //UC3 Removing avoidable word from the phrase
            hashtable.Remove("avoidable");
            Console.WriteLine("------------------------------------");
            hashtable.Display();
        }
    }
}