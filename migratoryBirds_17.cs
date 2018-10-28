// https://www.hackerrank.com/challenges/migratory-birds/problem

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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        var birdDict = arr.Distinct().ToDictionary(a => a, a => arr.Count(ar => ar == a));
        
        int maxValue = 0;
        int maxIndex = -1;
        foreach (var kvp in birdDict) {
            if ((kvp.Value == maxValue && kvp.Key < maxIndex) || (kvp.Value > maxValue)) {
                maxValue = kvp.Value;
                maxIndex = kvp.Key;
            }
        }
        return maxIndex;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
