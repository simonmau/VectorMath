using System;
using System.Globalization;

namespace VectorMath.Vector
{
    public struct Vector3D : IEquatable<Vector3D>
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

        /// <summary>
        /// rotating around the z axis
        /// </summary>
        public Vector3D RotateVector(double rotationAngle)
        {
            var sin = Math.Sin(rotationAngle);
            var cos = Math.Cos(rotationAngle);

            var x = cos * X - sin * Y;
            var y = sin * X + cos * Y;

            return new Vector3D(x, y, Z);
        }

        /// <summary>
        /// rotating around a given axis
        /// </summary>
        public Vector3D RotateVector(Vector3D axis, double rotationAngle)
        {
            var sin = Math.Sin(rotationAngle);
            var cos = Math.Cos(rotationAngle);

            var klammer = 1d - cos;

            var n1 = axis.X;
            var n2 = axis.Y;
            var n3 = axis.Z;

            var n1Sq = n1 * n1;
            var n2Sq = n2 * n2;
            var n3Sq = n3 * n3;

            var x = X * (n1Sq * klammer + cos) + Y * (n1 * n2 * klammer - n3 * sin) + Z * (n1 * n3 * klammer + n2 * sin);
            var y = X * (n2 * n1 * klammer + n3 * sin) + Y * (n2Sq * klammer + cos) + Z * (n2 * n3 * klammer - n1 * sin);
            var z = X * (n3 * n1 * klammer - n2 * sin) + Y * (n3 * n2 * klammer + n1 * sin) + Z * (n3Sq * klammer + cos);

            return new Vector3D(x, y, z);
        }

        public void Normalize()
        {
            var factor = 1d / Length();

            X *= factor;
            Y *= factor;
            Z *= factor;
        }

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

        public override bool Equals(object obj)
        {
            if (obj is Vector3D vector)
            {
                return Equals(vector);
            }

            return false;
        }

        public bool Equals(Vector3D other)
        {
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return X == other.X && Y == other.Y && Z == other.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }

        public override string ToString()
        {
            return $"Vector3D with X: {X.ToString(CultureInfo.InvariantCulture)}, Y: {Y.ToString(CultureInfo.InvariantCulture)}, Z: {Z.ToString(CultureInfo.InvariantCulture)}";
        }

        #endregion FUNCTIONS
    }
}