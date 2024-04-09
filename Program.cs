namespace HWRational
{
    //Part 1 (Class creation)
    class Rational
    {
        private int numerator;
        private int denominator;

        // Part 2 (Default)
        public Rational()
        {
            numerator = 0;
            denominator = 1;
        }

        // Part 6 (Parametric constructor)
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            Reduce(); // Reduce the fraction to its lowest terms
        }

        // Part 3
        public void WriteRational()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }

        // Part 7 (Reversing the sing of the rational number)
        public void Negate()
        {
            numerator = -numerator;
        }

        // Part 8 (Swaps numerator and denominator)
        public void Invert()
        {
            int temp = numerator;
            numerator = denominator;
            denominator = temp;
        }

        // Part 9 (converts rational number to double)
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }

        // Part 10 (divides by GCD)
        private void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;
        }

        // Calculates GDC
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Part 11 (sum of arguments)
        public static Rational Add(Rational r1, Rational r2)
        {
            int newNumerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int newDenominator = r1.denominator * r2.denominator;
            return new Rational(newNumerator, newDenominator);
        }

        // Part 4 (Main)
        static void Main(string[] args)
        {
            // Test for Rational class
            Console.WriteLine("Test for instance methods:");
            Rational r1 = new Rational(3, 4);
            Rational r2 = new Rational(1, 2);

            Console.Write("Rational number r1: ");
            r1.WriteRational();

            Console.Write("Rational number r2: ");
            r2.WriteRational();

            Console.Write("Negating r1: ");
            r1.Negate();
            r1.WriteRational();

            Console.Write("Inverting r2: ");
            r2.Invert();
            r2.WriteRational();

            Console.WriteLine("Converting r1 to double: " + r1.ToDouble());

            Rational sum = Rational.Add(r1, r2);
            Console.Write("Sum of r1 and r2: ");
            sum.WriteRational();

            Console.WriteLine();

            // Test for Rational2 class
            Console.WriteLine("Test for static methods:");
            Rational2 r3 = new Rational2(3, 4);
            Rational2 r4 = new Rational2(1, 2);

            Console.WriteLine("Rational number r3:");
            Rational2.WriteRational(r3);

            Console.WriteLine("Rational number r4:");
            Rational2.WriteRational(r4);

            Console.WriteLine("Negating r3:");
            Rational2.Negate(ref r3);
            Rational2.WriteRational(r3);

            Console.WriteLine("Inverting r4:");
            Rational2.Invert(ref r4);
            Rational2.WriteRational(r4);

            Console.WriteLine("Converting r3 to double: " + Rational2.ToDouble(r3));

            Rational2 sum2 = Rational2.Add(r3, r4);
            Console.WriteLine("Sum of r3 and r4:");
            Rational2.WriteRational(sum2);
        }
        class Rational2
        {
            public int Numerator { get; set; }
            public int Denominator { get; set; }

            // Default constructor
            public Rational2()
            {
                Numerator = 0;
                Denominator = 1;
            }

            // Parametric constructor
            public Rational2(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            // WriteRational static method
            public static void WriteRational(Rational2 r)
            {
                Console.WriteLine($"Rational number: {r.Numerator}/{r.Denominator}");
            }

            // Negate static method
            public static void Negate(ref Rational2 r)
            {
                r.Numerator = -r.Numerator;
            }

            // Invert static method
            public static void Invert(ref Rational2 r)
            {
                int temp = r.Numerator;
                r.Numerator = r.Denominator;
                r.Denominator = temp;
            }

            // ToDouble static method
            public static double ToDouble(Rational2 r)
            {
                return (double)r.Numerator / r.Denominator;
            }

            // Add static method
            public static Rational2 Add(Rational2 r3, Rational2 r4)
            {
                int numerator = (r3.Numerator * r4.Denominator) + (r4.Numerator * r3.Denominator);
                int denominator = r3.Denominator * r4.Denominator;
                return new Rational2(numerator, denominator);
            }
        }
    }
}
