using System;

namespace Square
{
    public static class Square
    {
        public static bool TriangleIsRight { get; set; }

        public static double GetSquare (double raduis)
        {
            const double pi = 3.1416;

            double square = 2 * pi * raduis;

            return square;
        }

        public static double GetSquare (double a, double b, double c)
        {
            double semi_perimetr = (a + b + c) / 2.0;

            //Heron's formula
            double square = Math.Sqrt(semi_perimetr * (semi_perimetr - a) * (semi_perimetr - b) * (semi_perimetr - c));

            TriangleIsRight = IsTriangleRight(a, b, c);

            return square;
        }

        static bool IsTriangleRight(double a, double b, double c)
        {
            return Pythagoras(a, b, c) || Pythagoras(b, c, a) || Pythagoras(c, a, b);
        }

        static bool Pythagoras(double a, double b, double c)
        {
            //It is too hart to be EXACTLY right traingle :)
            const double epsilon = 0.001;

            //Pythagorean theorem
            double difference = Math.Pow(c, 2) - (Math.Pow(a, 2) + Math.Pow(b, 2));

            bool is_right = Math.Abs(difference) < epsilon;

            return is_right;
        }
    }
}
