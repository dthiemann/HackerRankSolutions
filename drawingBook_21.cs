// https://www.hackerrank.com/challenges/drawing-book/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        /*
         * Write your code here.
         */
        int pageTurns = 0;
        if (p == n || p == 1) {
            return pageTurns;
        }
        
        if (n / 2 >= p) {            
            pageTurns++;
            int startPoint = 2;
            while (startPoint < n) {
                if (startPoint == p || startPoint + 1 == p) {
                    break;
                }
                
                pageTurns++;
                startPoint += 2;
            }
            
        } else {          
            if (n % 2 == 0) pageTurns++;

            int startPoint = n % 2 == 0 ? n - 1 : n;
            while (startPoint > 0) {
                if (startPoint == p || startPoint - 1 == p) {
                    break;
                }
                pageTurns++;
                startPoint -= 2;
            }
        }
        return pageTurns;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
