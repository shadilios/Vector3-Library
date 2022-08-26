namespace vector3_math
{
    public class Vector3
    {
        public float X;
        public float Y;
        public float Z;

        /// <summary>
        /// Returns the current vector normalized
        /// </summary>
        public Vector3 Normalized
        {
            get { return new Vector3(X / (float)Magnitude, Y / (float)Magnitude, Z / (float)Magnitude); }
        }

        /// <summary>
        /// Returns the magnitude of the current vector
        /// </summary>
        public double Magnitude
        {
            get { return MathF.Sqrt((X * X) + (Y * Y) + (Z * Z)); }
            
        }

        /// <summary>
        /// Returns the magnitude of the current vector squared
        /// </summary>
        public double MagnitudeSquared
        {
            get { return Magnitude * Magnitude; }
        }

        /// <summary>
        /// Creates a zero vector (0, 0, 0)
        /// </summary>
        public Vector3()
        {
            X = Y = Z = 0;
        }

        /// <summary>
        /// Creates a vector in 3D space with (x, y, z) dimensions
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }



        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        /// <summary>
        /// Normalizes the Vector3 so it becomes a unit Vector
        /// </summary>
        public void Normalize()
        {
            X = X / (float)Magnitude;
            Y = Y / (float)Magnitude;
            Z = Z / (float)Magnitude;
        }

        /// <summary>
        /// Performs CrossProduct between firstVector & secondVector
        /// </summary>
        /// <param name="firstVector"></param>
        /// <param name="secondVector"></param>
        /// <returns></returns>
        public static double DotProduct(Vector3 firstVector, Vector3 secondVector)
        {
            return (
                (firstVector.X * secondVector.X)
                + (firstVector.Y * secondVector.Y)
                + (firstVector.Z * firstVector.Z)
                );

            // or magnitude1 * magnitude2 * Cos theta

        }

        /// <summary>
        /// Performs CrossProduct between firstVector & secondVector
        /// </summary>
        /// <param name="firstVector"></param>
        /// <param name="secondVector"></param>
        /// <returns></returns>
        public static Vector3 CrossProduct(Vector3 firstVector, Vector3 secondVector)
        {

            float newX = firstVector.Y*secondVector.Z - firstVector.Z*secondVector.Y;
            float newY = firstVector.Z*secondVector.X - firstVector.X*secondVector.Z;
            float newZ = firstVector.X*secondVector.Y - firstVector.Y*secondVector.X; 

            return new Vector3(newX, newY, newZ);

            /*
            or a × b = |a| * |b| * sin(θ) * n
            where n: unit vector at right angles to both firstVector & secondVector
            */
        }

        /// <summary>
        /// Scales the vector by multiplying it by "number" argument
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public void Scale(float number)
        {
            X *= number;
            Y *= number;
            Z *= number;
        }
    }


}
