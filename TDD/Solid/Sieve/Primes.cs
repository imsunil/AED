using System;
using System.Collections.Generic;

public class Primes
{
    public static List<int> Generate(int maxValue)
    {
        if (maxValue < 2)
            return new List<int>();

        // declarations
        int size = maxValue + 1; // size of array
        bool[] searchArray = new bool[size];
        int i;

        // initialize the array to true
        for (i = 0; i < size; i++)
            searchArray[i] = true;

        // get rid of known non-primes
        searchArray[0] = searchArray[1] = false;

        // sieve
        int j;
        for (i = 2; i < Math.Sqrt(size) + 1; i++)
        {
            for (j = 2 * i; j < size; j += i)
                searchArray[j] = false; // multiple is not prime
        }

        // how many primes are there?
        int count = 0;
        for (i = 0; i < size; i++)
            if (searchArray[i]) // if prime
                count++; // bump count

        int[] primes = new int[count];

        // move the primes into the result
        for (i = 0, j = 0; i < size; i++)
        {
            if (searchArray[i]) // if prime
                primes[j++] = i;
        }

        return new List<int>(primes);
    }
}