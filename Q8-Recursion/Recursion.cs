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
            if (n == 1 || n == 2)
            {
                return 1 ;
            }
           return n =Fibonacci(n-2) + Fibonacci(n-1);
        }
    }
}