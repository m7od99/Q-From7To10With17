using System.Collections.Generic;
namespace newQuestions {
    public class Recursion {
        public static int Factorial (int n) {
            if (n == 1) return n;
            return n = (n) * Factorial (n - 1);
        }

        public static int Summation (int n) {
            if (n == 1) return n;
            return n = n + Summation (n - 1);
        }

        public static int Fibonacci(int n ){
            if (_memo.ContainsKey(n))
            {
                return _memo[n] ;
            }
            _memo[n] =Fibonacci(n-2) + Fibonacci(n-1);
            return  _memo[n];
        }
        public static Dictionary<int , int > _memo =  new Dictionary<int, int>{{0,0} , {1,1}};
    }
}