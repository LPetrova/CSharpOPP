namespace Point3D
{
    using System;

    public static class DistanceCalculator // Problem 2
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double result = 0;

            result = Math.Sqrt(
               (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X)
               +
               (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y)
               +
               (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z)
               );

            return result;
        }
    }
}
