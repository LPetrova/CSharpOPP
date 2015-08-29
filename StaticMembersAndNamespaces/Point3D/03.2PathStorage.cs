namespace Point3D
{
     using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

   public class PathStorage
    {
        private static readonly char[] Separators = new char[] { ',', ' ', '[', ']', ';' };

        public static void SavePaths(Path points, string filePath)
        {
            File.WriteAllText(filePath, points.ToString());
        }

        public static Path LoadPathFromFile(string file)
        {
            Path path3D = new Path();
            string[] pointsFromText = File.ReadAllText(file).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < pointsFromText.Length; i++)
            {
                string[] coordinates = pointsFromText[i].Split(Separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

                path3D.AddPoint(new Point3D(double.Parse(coordinates[1]), double.Parse(coordinates[3]), double.Parse(coordinates[5])));
            }

            return path3D;
        }

    }
}
