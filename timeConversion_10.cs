// https://www.hackerrank.com/challenges/time-conversion/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        /*
         * Write your code here.
         */
        var isMorning = s.EndsWith("AM");
        var tokens = s.Split(':');
        var hour = tokens[0];
        var minutes = tokens[1];
        var seconds = tokens[2].Substring(0,2);
        
        string newHour;
        
        if (isMorning) {
            if (hour == "12")
                newHour = "00";
            else
                newHour = hour;
        }
        else {
            if (hour == "12") 
                newHour = hour;
            else {
                int hourInt = Convert.ToInt32(hour) + 12;
                newHour = hourInt.ToString();
            }
        }
        return $"{newHour}:{minutes}:{seconds}";
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
