﻿using System;

/* Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer */

public class Kata
{
        public static int SquareDigits(int n)
    {
        string output = "";
        foreach (char c in n.ToString())
        {
        int square = int.Parse(c.ToString());
        output += (square * square);
        }
        return int.Parse(output);
    }
}
