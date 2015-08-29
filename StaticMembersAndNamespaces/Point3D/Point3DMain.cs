using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Point3DMain
    {
        static void Main(string[] args)
        {
            // Examples
            Point3D p1 = new Point3D(5.4, 6.2, 3);
            Point3D p2 = new Point3D(7.9, 2.1, 5.9);
            Point3D p3 = new Point3D(23.4, 3, 5);
            Point3D p4 = new Point3D(7, 15.5, 57.7);

            // Create sequence of points ( List<Point3D> )
            Path points = new Path();

            Console.WriteLine("The Path of 3D points is created.\n");

            // Add points in the sequence
            Console.WriteLine("Adding some 3D points...");
            points.AddPoint(p1);
            points.AddPoint(p2);
            points.AddPoint(p3);
            points.AddPoint(p4);
            Console.WriteLine(points);

            //Remove some points
            Console.WriteLine("\nRemoving first and last 3D point from tha Path...\n");
            points.RemovePoint(p1);
            points.RemovePoint(p4);

            Console.WriteLine("Now the Path contains:");
            Console.WriteLine(points.ToString());

            // Calculate distance between two 3D points
            Console.WriteLine("\nCalculate the distance between two 3D points:\n");
            Console.WriteLine("{0:F2} cm", DistanceCalculator.CalculateDistance(p2, p3));

            // Save points into text file
            PathStorage.SavePaths(points, "PointsFromText.txt");
            Console.WriteLine("\nThe Path of 3D Points is saved in text file.");
            Console.WriteLine("You can find it at: Current Project\\bin\\Debug\\PointsFromText.txt"); 

        }
    }
}
