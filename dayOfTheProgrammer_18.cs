// https://www.hackerrank.com/challenges/day-of-the-programmer/problem

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

    // Complete the dayOfProgrammer function below.
    static string dayOfProgrammer(int year) {
        Dictionary<int, int> calendar = new Dictionary<int,int>() {
            {1 , 31},
            {2 , 28},
            {3 , 31},
            {4 , 30},
            {5 , 31},
            {6 , 30},
            {7 , 31},
            {8 , 31},
            {9 , 30},
            {10 , 31},
            {11 , 30},
            {12 , 31},
        };
        if (year == 1918) {
            calendar[2] = 15;
        }
        
        if (IsLeapYear(year)) calendar[2]++;
        
        var currentMonth = 1;
        var total = 256;
        var totalDays = 0;
        while (totalDays < total) {
            totalDays += calendar[currentMonth];
            currentMonth++;
        }
        string month;
        if (currentMonth - 1 < 10) {
            month = "0" + (currentMonth-1).ToString();
        } else {
            month = (currentMonth - 1).ToString();
        }
        
        
        return $"{calendar[currentMonth-1] - (totalDays - total)}.{month}.{year}";

    }
    
    static bool IsLeapYear(int year) {
        if (year < 1918) {
            return year % 4 == 0;
        } 
        else {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
