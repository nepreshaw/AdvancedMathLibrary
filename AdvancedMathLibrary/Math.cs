using System;


namespace AdvancedMathLibrary {
    public static class Math {
        public static int AbsoluteValue(int a) {
            return (a < 0) ? -a : a; 
        }

        public static int Add(int a, int b) {
            return a + b;
        }
            
        public static int Subtract(int a, int b) {
            return a - b;
        }

        public static int Multiply(int a, int b) {
            return a * b;
        }

        public static decimal Divide(decimal a, decimal b) {
            return a / b;
        }

        
    }
}
