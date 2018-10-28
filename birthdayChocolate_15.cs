// https://www.hackerrank.com/challenges/the-birthday-bar/problem

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

    // Complete the birthday function below.
    static int birthday(List<int> s, int d, int m) {
        int waysToCut = 0;
        for (var i = 0; i < s.Count(); i++) {
            //if (SubArray(s.ToArray(), i, i + m >= s.Count() ? s.Count() - 1 : i + m).Sum() == d) 
            //    waysToCut++;
            var sum = 0;
            for (var j = 0; j < m; j ++) {
                if (i+j >= s.Count()) {
                    break;
                }
                
                sum += s[i + j];
            }
            
            if (sum == d) {
                waysToCut++;
            }
        }
        return waysToCut;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

        string[] dm = Console.ReadLine().TrimEnd().Split(' ');

        int d = Convert.ToInt32(dm[0]);

        int m = Convert.ToInt32(dm[1]);

        int result = birthday(s, d, m);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
