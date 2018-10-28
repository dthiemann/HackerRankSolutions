// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem

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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        var highScore = scores[0];
        var lowScore = scores[0];
        
        var beatScores = new int[] {0, 0};
        
        for (var i = 1; i < scores.Count(); i++) {
            if (scores[i] > highScore) {
                highScore = scores[i];
                beatScores[0]++;
            }
            if (scores[i] < lowScore) {
                lowScore = scores[i];
                beatScores[1]++;
            }
        }
        
        return beatScores;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
