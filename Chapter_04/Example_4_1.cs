using System;
namespace Chapter_04
{
    public class Circle
    {
        protected double radius;
        public Circle(double r) { radius = r; }
        public double GetArea() { return Math.PI * radius * radius; }
    }
    public class Sphere : Circle//球体类
    {
        public Sphere(double r) : base(r) { }
        public double GetArea() { return (4 * base.GetArea()); }
        public double GetVolumn()
        { return (4 * Math.PI * Math.Pow(radius, 3) / 3); }
    }
    public class Cylinder : Circle//圆柱类
    {
        private double height;//添加高度字段
        public Cylinder(double r, double h) : base(r) { height = h; }
        public double GetArea()
        { return (2 * base.GetArea() + 2 * Math.PI * radius * height); }
        public double GetVolumn() { return (Math.PI * radius * radius * height); }
    }
    public class Cone : Circle//圆锥类
    {
        private double height;//添加高度字段
        public Cone(double r, double h) : base(r) { height = h; }
        public double GetArea()
        { return (Math.PI * radius * (radius + Math.Sqrt(height * height + radius * radius))); }
        public double GetVolumn()
        { return (Math.PI * radius * radius * height / 3); }
    }
    //public class Tester
    //{
    //    public static void Main()
    //    {
    //        Circle c1 = new Circle(2);
    //        Sphere s1 = new Sphere(2);
    //        Cylinder cd1 = new Cylinder(2, 10);
    //        Cone cn1 = new Cone(2, 10);
    //        Console.WriteLine("s1's serfacearea={0},volumn={1}", s1.GetArea(), s1.GetVolumn());
    //        Console.WriteLine("cd1's serfacearea={0},volumn={1}", cd1.GetArea(), cd1.GetVolumn());
    //        Console.WriteLine("cn1's serfacearea={0},volumn={1}", cn1.GetArea(), cn1.GetVolumn());
    //        Console.ReadLine();
    //    }
    //}
}