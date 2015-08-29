namespace Point3D
{
    using System;
    
    public struct Point3D
    {
        public static readonly Point3D startPoint;

        //Fields
        private double x;       //problem 1
        private double y;
        private double z;

        //Static constructors
        static Point3D()                   //problem 2
        {
            startPoint = new Point3D(0, 0, 0);
        }

        //Constructors with parameters
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        //Priperties                          problem 1
        public static Point3D StartPoint
        {
            get { return startPoint; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        // Override method ToSTring()
        public override string ToString()
        {
            return string.Format("[X: {0} ; Y: {1} ; Z: {2} ]", this.X, this.Y, this.Z);
        }

    }
}
