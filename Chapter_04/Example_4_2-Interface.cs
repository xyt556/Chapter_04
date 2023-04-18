using System;

namespace Chapter_04
{
    public interface ICalAreaAndVolumn //声明接口
    {
        double GetArea();
    }
    public class Sphere : ICalAreaAndVolumn //球类
    {
        private double radius;
        public Sphere(double r) { radius = r; }
        public double GetArea()//接口成员的隐式实现
        { return (4 * Math.PI * radius * radius); }
    }
    public class Cylinder : ICalAreaAndVolumn //圆柱类
    {
        private double radius, height;
        public Cylinder(double r, double h) { radius = r; height = h; }
        public double GetArea()
        {
            return (2 * Math.PI * radius * radius + 2 * Math.PI * radius * height);
        }
    }
    public class Cone : ICalAreaAndVolumn //圆锥类
    {
        private double radius, height;
        public Cone(double r, double h) { radius = r; height = h; }
        public double GetArea()
        {
            return (Math.PI * radius * (radius + Math.Sqrt(height * height + radius * radius)));
        }
    }
    //public class MyApp
    //{
    //    public static double SumAreas(ICalAreaAndVolumn[] array)
    //    {
    //        double tot = 0.0;
    //        for (int i = 0; i < array.Length; i++)
    //        { tot += array[i].GetArea(); }
    //        return tot;
    //    }
    //    public static void Main()
    //    {
    //        Sphere sp = new Sphere(2);
    //        Cylinder cd = new Cylinder(2, 10);
    //        Cone cn = new Cone(2, 20);
    //        ICalAreaAndVolumn[] array = { sp, cd, cn };
    //        Console.WriteLine("total arears = {0}", SumAreas(array));
    //    }
    //}
}