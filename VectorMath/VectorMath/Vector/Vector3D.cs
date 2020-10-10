using System;

namespace VectorMath.Vector
{
    public struct Vector3D
    {
        public static Vector3D UnitVector => new Vector3D(1d, 1d, 1d);
        public static Vector3D ZeroVector => new Vector3D(0d, 0d, 0d);

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        #region ADD

        public void Add(Vector3D vector)
        {
            X += vector.X;
            Y += vector.Y;
            Z += vector.Z;
        }

        public void Add(double number)
        {
            X += number;
            Y += number;
            Z += number;
        }

        public static Vector3D operator +(Vector3D left, Vector3D right)
        {
            return new Vector3D(left.X + right.X, left.Y + right.Y, left.Z + right.Z);
        }

        public static Vector3D operator +(Vector3D left, double right)
        {
            return new Vector3D(left.X + right, left.Y + right, left.Z + right);
        }

        #endregion ADD

        #region SUBTRACT

        public void Subtract(Vector3D vector)
        {
            X -= vector.X;
            Y -= vector.Y;
            Z -= vector.Z;
        }

        public void Subtract(double number)
        {
            X -= number;
            Y -= number;
            Z -= number;
        }

        public static Vector3D operator -(Vector3D left, Vector3D right)
        {
            return new Vector3D(left.X - right.X, left.Y - right.Y, left.Z - right.Z);
        }

        public static Vector3D operator -(Vector3D left, double right)
        {
            return new Vector3D(left.X - right, left.Y - right, left.Z - right);
        }

        #endregion SUBTRACT

        #region MULTIPLY

        public void Multiply(double number)
        {
            X *= number;
            Y *= number;
            Z *= number;
        }

        public static Vector3D operator *(Vector3D left, double right)
        {
            return new Vector3D(left.X * right, left.Y * right, left.Z * right);
        }

        #endregion MULTIPLY

        #region DIVIDE

        public void Divide(double number)
        {
            var divisor = 1d / number;

            X *= divisor;
            Y *= divisor;
            Z *= divisor;
        }

        public static Vector3D operator /(Vector3D left, double right)
        {
            var divisor = 1d / right;

            return new Vector3D(left.X * divisor, left.Y * divisor, left.Z * divisor);
        }

        #endregion DIVIDE

        #region FUNCTIONS

        public Vector3D CrossProduct(Vector3D right)
        {
            var x = Y * right.Z - Z * right.Y;
            var y = Z * right.X - X * right.Z;
            var z = X * right.Y - Y * right.X;

            return new Vector3D(x, y, z);
        }

        public double ScalarProduct(Vector3D right)
        {
            return X * right.X + Y * right.Y + Z * right.Z;
        }

        public double LengthSquared()
        {
            return X * X + Y * Y + Z * Z;
        }

        public double Length()
        {
            return Math.Sqrt(LengthSquared());
        }

        #endregion FUNCTIONS
    }
}