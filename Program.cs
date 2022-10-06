using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

FizzBuzz();
StockMerchant();
PalindromeCheck("Malayalam");

void PalindromeCheck(string word)
{
    string revs = "";

    for (int i = word.Length - 1; i >= 0; i--)
    {
        revs += word[i].ToString();
    }
    Console.WriteLine(revs.ToLower().Trim() == word.ToLower().Trim() ? "{0} is Palindrome" : "{0} is not Palindrome", word);

}

void StockMerchant()
{
    int[] arr = new int[] { 1, 2, 1, 2, 1, 3, 2 };


    Console.WriteLine("Pairs in the array {0}", Pair(arr));
    Console.WriteLine("No pairs in the array {0}", NoPair(arr));
}

void FizzBuzz()
{
    for (int i = 0; i < 100; i++)
    {
        bool fizz = i % 3 == 0;
        bool buzz = i % 5 == 0;

        if (fizz && buzz)
            Console.WriteLine("FizzBuzz");
        else if (fizz)
            Console.WriteLine("Fizz");
        else if (buzz)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine(i);
    }
}


int NoPair(int[] ar)
{
    return ar.GroupBy(i => i).Where(g => g.Count() % 2 == 1).Select(g => g.Key).Count();
}


int Pair(int[] ar)
{
    Array.Sort(ar);
    int numberOfPairs = 0;

    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] == ar[i++])
        {
            numberOfPairs++;
            i += 1;
        }
    }
    return numberOfPairs % 2 == 0 ? numberOfPairs : numberOfPairs-1;
}