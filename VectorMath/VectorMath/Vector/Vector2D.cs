using System;

namespace VectorMath.Vector
{
    public struct Vector2D
    {
        public static Vector2D UnitVector => new Vector2D(1d, 1d);
        public static Vector2D ZeroVector => new Vector2D(0d, 0d);

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        #region ADD

        public void Add(Vector2D vector)
        {
            X += vector.X;
            Y += vector.Y;
        }

        public void Add(double number)
        {
            X += number;
            Y += number;
        }

        public static Vector2D operator +(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X + right.X, left.Y + right.Y);
        }

        public static Vector2D operator +(Vector2D left, double right)
        {
            return new Vector2D(left.X + right, left.Y + right);
        }

        #endregion ADD

        #region SUBTRACT

        public void Subtract(Vector2D vector)
        {
            X -= vector.X;
            Y -= vector.Y;
        }

        public void Subtract(double number)
        {
            X -= number;
            Y -= number;
        }

        public static Vector2D operator -(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X - right.X, left.Y - right.Y);
        }

        public static Vector2D operator -(Vector2D left, double right)
        {
            return new Vector2D(left.X - right, left.Y - right);
        }

        #endregion SUBTRACT

        #region MULTIPLY

        public void Multiply(double number)
        {
            X *= number;
            Y *= number;
        }

        public static Vector2D operator *(Vector2D left, double right)
        {
            return new Vector2D(left.X * right, left.Y * right);
        }

        #endregion MULTIPLY

        #region DIVIDE

        public void Divide(double number)
        {
            var divisor = 1d / number;

            X *= divisor;
            Y *= divisor;
        }

        public static Vector2D operator /(Vector2D left, double right)
        {
            var divisor = 1d / right;

            return new Vector2D(left.X * divisor, left.Y * divisor);
        }

        #endregion DIVIDE

        #region FUNCTIONS

        public double ScalarProduct(Vector2D right)
        {
            return X * right.X + Y * right.Y;
        }

        public double LengthSquared()
        {
            return X * X + Y * Y;
        }

        public double Length()
        {
            return Math.Sqrt(LengthSquared());
        }

        #endregion FUNCTIONS
    }
}