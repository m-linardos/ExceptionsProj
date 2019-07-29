using System;

namespace ExceptionsProj {
    class Program {
        static void Main(string[] args) {
            try {
                int answer = Level1.Divide(4, 2);
                Console.WriteLine($"4 / 2 is {answer}");

            }
            catch (DivideByZeroException ex) {
                Console.WriteLine("b is not allowed to be zero.");
            }
            catch (DivideByZeroException ex) {
                Console.WriteLine($"unknown exception. Message is {ex.Message}");
            }
            
            }
    }
    class Level1 {
        public static int Divide(int a, int b) {
            int answer = Level2.Divide(a, b);
            return answer;
        }
    }

    class Level2 {
        public static int Divide(int a, int b) {
            int answer = Level3.Divide(a, b);
            return answer;
        }
    }

    class Level3 {
        public static int Divide(int a, int b) {
            throw new ExecutionEngineException("We generated this exception.");
            int answer = Level3.Divide(int a, int b) {

            
            //try {
            //    int answer = a / (b - b);           // when exception occurs, it immediately jumps to catch block.  return statement skipped.
            //    return answer;
            //}
            //catch (DivideByZeroException ex) {
            //    Console.WriteLine("b is not allowed to be zero.");
            /*return -1;*/              // must return somethin, otherwise an error
            return answer;
            }
        }
    }

}
