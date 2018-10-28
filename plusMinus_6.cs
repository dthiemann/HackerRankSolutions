// https://www.hackerrank.com/challenges/plus-minus/problem

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        var positive = arr.Count(a => a > 0);
        var negative = arr.Count(a => a < 0);
        var zero = arr.Count(a => a == 0);
        
        Console.WriteLine((double)positive / arr.Count());        
        Console.WriteLine((double)negative / arr.Count());
        Console.WriteLine((double)zero / arr.Count());
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
