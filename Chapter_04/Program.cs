using System;

namespace Chapter_04
{
    #region eg4.1：继承-构造函数

    #region 错误代码1

    //class Rock
    //{
    //    public Rock(int i)
    //    { }
    //}
    //class IgneousRock : Rock
    //{
    //    public IgneousRock(int i) { }
    //}

    #endregion

    #region 改正方法1：修改基类构造函数

    //class Rock
    //{
    //    public Rock()
    //    { }
    //}
    //class IgneousRock : Rock
    //{
    //    public IgneousRock(int i) { }
    //}

    #endregion

    #region 改正方法2：派生类使用base显示调用基类构造函数
    //class Rock
    //{
    //    public Rock(int i)
    //    { }
    //}
    //class IgneousRock : Rock
    //{
    //    public IgneousRock(int i) : base(i) { }
    //}

    #endregion


    #region 错误代码2
    //class Rock
    //{
    //}
    //class IgneousRock : Rock
    //{
    //    public IgneousRock(int i) : base(i) { }
    //}
    #endregion

    #region 改正方法1：修改基类构造函数
    //请添加正确的代码至此;

    #endregion

    #region 改正方法2：修改派生类构造函数
    //请添加正确的代码至此;

    #endregion
    #endregion

    #region eg4.2：继承-调用基类方法
    //class Rock
    //{
    //    public Rock()
    //    { }
    //    protected void Structure() { Console.WriteLine("调用基类方法成功！"); }
    //}
    //class IgneousRock : Rock
    //{
    //    public IgneousRock() { }
    //    void Structure() { Console.WriteLine("调用继承类方法成功！"); }
    //    public void Structure1()
    //    {
    //        base.Structure();
    //        Structure();
    //    }
    //}
    //class MyApp
    //{
    //    static void Main()
    //    {
    //        IgneousRock myRock = new IgneousRock();
    //        myRock.Structure1();
    //    }
    //}
    #endregion

    #region eg4.3: 继承格式
    //public class Parent //建立基类
    //{
    //    public Parent(string str) //基类带参数构造函数
    //    { Console.WriteLine(str); }
    //    public void ShowPosition() //基类方法
    //    { Console.WriteLine("基类的位置在（0，0）"); }
    //}
    //public class Child : Parent //派生子类
    //{
    //    public Child()
    //        : base("调用基类构造") //子类构造函数，调用基类构造函数
    //    { Console.WriteLine("I am child"); }
    //    public void ShowPosition()
    //    {
    //        base.ShowPosition(); //调用基类方法
    //        Console.WriteLine("派生类的位置在（10,10）");
    //    }
    //}
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Parent prt = new Parent("I am a parent");
    //        Child chd = new Child();
    //        prt.ShowPosition();
    //        chd.ShowPosition();
    //    }
    //}
    #endregion

    #region 继承补充示例：方法的覆盖（override）和隐藏（new）
    //class A
    //{
    //    public virtual void Print() { Console.WriteLine("A"); }
    //}
    //class B : A
    //{
    //    public new void Print()//类B隐藏了A的同名方法，但B中实际有2个Print方法
    //    {
    //        Console.WriteLine("B");
    //    }
    //}
    //class C : A
    //{
    //    public override void Print()//类C覆盖了A的同名方法，类中只有1个Print方法
    //    {
    //        Console.WriteLine("C");
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        A a1 = new B();//a1是基类的对象，指向派生类的引用而已，
    //        a1.Print();    //因此只会调用基类的方法；
    //        B b1 = new B();//b1是派生类的对象，
    //        b1.Print();    //因隐藏了A的方法，因此只会调用自己类中定义的Print
    //        A a2 = new C();//a2同样式基类的对象指向派生类，
    //        a2.Print();//但因派生类覆盖了基类方法，因此只能调用派生类的方法
    //    }
    //}

    #endregion

    #region eg4.4: 类的继承示例--表面积与体积
    //public class Circle
    //{
    //    protected double radius;
    //    public Circle(double r)
    //    {
    //        radius = r;
    //    }
    //    public double GetArea()
    //    {
    //        return Math.PI * radius * radius;
    //    }
    //}
    //public class Sphere : Circle //球体类
    //{
    //    public Sphere(double r) : base(r) { }
    //    public new double GetArea()
    //    {
    //        return 4 * base.GetArea();
    //    }
    //    public double GetVolumn()
    //    {
    //        return (4 * Math.PI * Math.Pow(radius, 3) / 3);
    //    }
    //}
    //public class Cylinder : Circle//圆柱类
    //{
    //    private double height;//添加高度字段
    //    public Cylinder(double r, double h)
    //        : base(r)
    //    {
    //        height = h;
    //    }
    //    public new double GetArea()
    //    {
    //        return (2 * base.GetArea() + 2 * Math.PI * radius * height);
    //    }
    //    public double GetVolumn()
    //    {
    //        return (Math.PI * radius * radius * height);
    //    }
    //}
    //public class Cone : Circle//圆锥类
    //{
    //    private double height;//添加高度字段
    //    public Cone(double r, double h)
    //        : base(r)
    //    {
    //        height = h;
    //    }
    //    public new double GetArea()
    //    {
    //        return (Math.PI * radius * (radius + Math.Sqrt(height * height + radius * radius)));
    //    }
    //    public double GetVolumn()
    //    {
    //        return (Math.PI * radius * radius * height / 3);
    //    }
    //}
    //public class Tester
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("eg4.4：继承-构造函数");
    //        Circle c1 = new Circle(2);
    //        Sphere s1 = new Sphere(5);
    //        Cylinder cd1 = new Cylinder(5, 50);
    //        Cone cn1 = new Cone(2, 10);
    //        Console.WriteLine("circle area={0}", c1.GetArea());
    //        Console.WriteLine("s1's surface area={0}, volumn={1}", s1.GetArea(), s1.GetVolumn());
    //        Console.WriteLine("cd1's surface area={0}, volumn={1}", cd1.GetArea(), cd1.GetVolumn());
    //        Console.WriteLine("cn1's surface area={0}, volumn={1}", cn1.GetArea(), cn1.GetVolumn());
    //    }
    //}

    #endregion

    #region eg4.5: 抽象类
    //abstract class WashingMachine
    //{
    //    public WashingMachine()//构造函数
    //    {
    //        Console.WriteLine("here is WashingMachine ");
    //    }
    //    abstract public void Wash(); //抽象方法
    //    abstract public void Rinse(int loadSize); //抽象方法
    //    abstract public long Spin(int speed); //抽象方法
    //}
    //class MyWashingMachine : WashingMachine
    //{
    //    public MyWashingMachine()
    //    { Console.WriteLine("here is MyWashingMachine "); }
    //    override public void Wash()
    //    { Console.WriteLine("Wash"); }
    //    override public void Rinse(int loadSize)
    //    { Console.WriteLine("Rinse"); }
    //    override public long Spin(int speed)
    //    { Console.WriteLine("Spin"); return (speed * 1000); }
    //}

    //class Program
    //{
    //    public static void Main()
    //    {
    //        //WashingMachine m = new WashingMachine();//这句是错误的
    //        MyWashingMachine mm = new MyWashingMachine();
    //    }
    //} 
    #endregion

    #region eg4.6：委托

    // 委托定义
    //public delegate int Call(int n1, int n2);
    //class Math
    //{
    //    // 乘法方法
    //    public int Multiply(int n1, int n2)
    //    {
    //        return n1 * n2;
    //    }

    //    // 除法方法
    //    public int Divide(int n1, int n2)
    //    {
    //        if (n2 != 0)
    //            return n1 / n2;
    //        else return -999;
    //    }
    //}
    //class Delegates
    //{
    //    static void Main(string[] args)
    //    {
    //        // 委托的对象
    //        Call objCall;

    //        // Math 类的对象
    //        Math objMath = new Math();

    //        // 将方法与委托关联起来
    //        objCall = new Call(objMath.Multiply);

    //        // 将委托实例化
    //        int result = objCall(4, 3);
    //        Console.WriteLine("结果为 {0}", result);

    //        objCall = new Call(objMath.Divide);
    //        result = objCall(4, 3);
    //        Console.WriteLine("结果为{0}", result);
    //    }
    //}

    #endregion

    #region eg4.7：委托与事件

    //class ClassA
    //{
    //    public void DispMethod()
    //    {
    //        Console.WriteLine("Class A已接到NotifyEveryOne事件的通知！");
    //    }
    //}
    //// 第二个类
    //class ClassB
    //{
    //    public void DispMethod()
    //    {
    //        Console.WriteLine("Class B已接到NotifyEveryOne事件的通知！");
    //    }
    //}
    //class Delegate
    //{
    //    // 定义委托
    //    public delegate void MeDelegate();
    //    // 定义事件
    //    public event MeDelegate NotifyEveryOne;

    //    public void Notify()
    //    {
    //        // 如果事件不为 null
    //        if (NotifyEveryOne != null)
    //        {
    //            Console.WriteLine("触发事件：");

    //            NotifyEveryOne();// 触发事件
    //        }
    //    }
    //}
    //class TestEvents
    //{
    //    static void Main(string[] args)
    //    {
    //        // 委托的对象
    //        Delegate objDelegate = new Delegate();
    //        // ClassA 的对象
    //        ClassA objClassA = new ClassA();
    //        // ClassB 的对象
    //        ClassB objClassB = new ClassB();
    //        // 订阅该事件
    //        objDelegate.NotifyEveryOne +=
    //           new Delegate.MeDelegate(objClassA.DispMethod);
    //        objDelegate.NotifyEveryOne +=
    //           new Delegate.MeDelegate(objClassB.DispMethod);

    //        objDelegate.Notify();
    //    }
    //}

    #endregion

    #region eg4.8-FileStream

    //using System.IO;
    //public class MyApp
    //{
    //    static void Main()
    //    {
    //        try
    //        {
    //            FileStream fs = new FileStream(Directory.GetCurrentDirectory() + @"\newGP.txt",
    //                FileMode.OpenOrCreate, FileAccess.ReadWrite);

    //            byte[] alpha = new byte[6] { 65, 66, 67, 68, 69, 70 };
    //            foreach (byte b in alpha)
    //            {
    //                fs.WriteByte(b);
    //            }
    //            fs.Position = 0;
    //            for (int i = 0; i < fs.Length; i++)
    //            {
    //                Console.Write((char)fs.ReadByte());
    //            }
    //            fs.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.Write(ex.Message);
    //        }
    //    }
    //}

    #endregion

    #region eg4.9-MemoryStream

//    using System.IO;

//    public class MyApp
//    {
//        static void Main()
//        {
//            try
//            {
//                // 打开一个用于读取的文件流，指向当前目录下名为"C#.bmp"的文件
//                FileStream fsIn = new FileStream(Directory.GetCurrentDirectory() + @"\C#.bmp", FileMode.Open, FileAccess.Read);

//                // 打开一个用于写入的文件流，指向当前目录下名为"newC#.bmp"的文件
//                FileStream fsOut = new FileStream(Directory.GetCurrentDirectory() + @"\newC#.bmp", FileMode.OpenOrCreate, FileAccess.Write);

//                // 创建一个内存流
//                MemoryStream ms = new MemoryStream();

//                int imgByte;

//                // 从输入文件流中读取字节，直到读取完毕
//                while ((imgByte = fsIn.ReadByte()) != -1)
//                    ms.WriteByte((byte)imgByte); // 将读取到的字节写入内存流

//                // 将内存流中的数据写入输出文件流
//                ms.WriteTo(fsOut);

//                // 将内存流中的数据转换为字节数组
//                byte[] imgArray = ms.ToArray();

//                // 关闭非托管资源
//                fsIn.Close();
//                fsOut.Close();
//                ms.Close();
//            }
//            catch (Exception ex)
//            {
//                Console.Write(ex.Message);
//            }
//        }
//    }
//}

#endregion

#region eg-BufferStream ~
//using System.IO;
//public class BuffStream
//{
//    public void SaveStream()
//    {
//        Stream fsOut1 = new FileStream(@"C:\Users\LJH\Desktop\GP.txt",
//           FileMode.OpenOrCreate, FileAccess.Write);
//        BufferedStream fileBuffer = new BufferedStream(fsOut1);
//        byte[] buff;			// array to hold bytes written to buffer
//        bool readMore = true;
//        while (readMore)
//        {
//            buff = FillBytes();			// Get array of bytes
//            Console.WriteLine(buff[16]);
//            for (int j = 0; j < buff[16]; j++)
//            {
//                fileBuffer.WriteByte(buff[j]);	// store bytes in buffer

//            }
//            if (buff[16] < 16) readMore = false;   // indicates no more data
//        }
//        fileBuffer.Close();  // flushes all remaining buffer content
//        fsOut1.Close();      // Must close after bufferedstream
//    }
//    // method to simulate I/O device receiving data
//    private static byte[] FillBytes()
//    {
//        Random rand = new Random();
//        byte[] r = new Byte[17];
//        // store random numbers to  return in array
//        for (int j = 0; j < 16; j++)
//        {

//            r[j] = (byte)rand.Next();
//            if (r[j] == 171)		   // Arbitrary end of stream value
//            {
//                r[16] = (byte)(j);	   // Number of bytes in array
//                return r;
//            }
//        }
//        r[16] = (byte)16;           // entire buffer was filled
//        System.Threading.Thread.Sleep(200); // Delay 500ms 
//        return r;
//    }
//}
//public class MyApp
//{
//    static void Main()
//    {
//        BuffStream bs = new BuffStream();
//        bs.SaveStream();
//        Console.WriteLine("Buffered data written.");
//        Console.Read();
//    }
//}
#endregion

#region eg4.10-读文本文件
//using System.IO;
//using System.Text;

//class Class1
//{     //多线程COM时使用[MTAThread]
//    [STAThread]
//    static void Main(string[] args)
//    {
//        StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + @"\GP.txt",
//            Encoding.GetEncoding("gb2312"));
//        string line;
//        while ((line = sr.ReadLine()) != null)
//        {
//            Console.WriteLine(line);
//        }
//        sr.Close();
//        Console.ReadLine();
//    }
//}

#endregion

#region eg4.11-写文本文件

//using System.IO;
//using System.Text;

//class Class1
//{
//    [STAThread]
//    static void Main(string[] args)
//    {
//        StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"\GP.txt",
//                                true, Encoding.GetEncoding("gb2312"));
//        string data = "\n hello world, how are you";
//        sw.WriteLine(data);
//        sw.Close();

//    }
//}
#endregion

#region eg4.12-Path类
//using System.IO;
//class Test
//{
//    public static void Main()
//    {
//        string path1 = @"c:\temp\MyTest.txt";
//        string path2 = @"c:\temp\MyTest";
//        string path3 = @"temp";
//        if (Path.HasExtension(path1))
//        {
//            Console.WriteLine("{0} has an extension.", path1);
//        }
//        if (!Path.HasExtension(path2))
//        {
//            Console.WriteLine("{0} has no extension.", path2);
//        }
//        if (!Path.IsPathRooted(path3))
//        {
//            Console.WriteLine("The string {0} contains no root information.", path3);
//        }
//        Console.WriteLine("{0} is the location for temporary files.",
//               Path.GetTempPath());
//        Console.WriteLine("{0} is a file available for use.", Path.GetTempFileName());
//    }
//}

#endregion

#region Interface

//public interface ICalAreaAndVolumn //声明接口
//{
//    double GetArea();
//}
//public class Sphere : ICalAreaAndVolumn //球类
//{
//    private double radius;
//    public Sphere(double r) { radius = r; }
//    public double GetArea()//接口成员的隐式实现
//    { return (4 * Math.PI * radius * radius); }
//}
//public class Cylinder : ICalAreaAndVolumn //圆柱类
//{
//    private double radius, height;
//    public Cylinder(double r, double h) { radius = r; height = h; }
//    public double GetArea()
//    {
//        return (2 * Math.PI * radius * radius + 2 * Math.PI * radius * height);
//    }
//}
//public class Cone : ICalAreaAndVolumn //圆锥类
//{
//    private double radius, height;
//    public Cone(double r, double h) { radius = r; height = h; }
//    public double GetArea()
//    {
//        return (Math.PI * radius * (radius + Math.Sqrt(height * height + radius * radius)));
//    }
//}
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
#endregion

#region Class and Interface example
//public class MyApp
//{
//    public static double SumAreas(ClassAndInterface.ICalAreaAndVolumn[] array)
//    {
//        double tot = 0.0;
//        for (int i = 0; i < array.Length; i++)
//        { tot += array[i].GetArea(); }
//        return tot;
//    }
//    public static void Main()
//    {
//        ClassAndInterface.Sphere sp = new ClassAndInterface.Sphere(2);
//        ClassAndInterface.Cylinder cd = new ClassAndInterface.Cylinder(2, 10);
//        ClassAndInterface.Cone cn = new ClassAndInterface.Cone(2, 20);
//        ClassAndInterface.ICalAreaAndVolumn[] array = { sp, cd, cn };
//        Console.WriteLine("total area = {0}", SumAreas(array));

//        double totalArea = 0;
//        double totalVolumn = 0;
//        ClassAndInterface.ICalAreaAndVolumn itf = new ClassAndInterface.Sphere(2);
//        Console.WriteLine("Sphere: (r={0}), area={1}, volumn={2}", 2, itf.GetArea(), itf.GetVolumn());
//        totalArea += itf.GetArea();
//        totalVolumn += itf.GetVolumn();

//        itf = new ClassAndInterface.Cylinder(2, 10);
//        Console.WriteLine("Cylinder: (r={0}, h={1}), area={2}, volumn={3}", 2, 10, itf.GetArea(), itf.GetVolumn());
//        totalArea += itf.GetArea();
//        totalVolumn += itf.GetVolumn();

//        itf = new ClassAndInterface.Cone(2, 20);
//        Console.WriteLine("Cone: (r={0}, h={1}), area={2}, volumn={3}", 2, 20, itf.GetArea(), itf.GetVolumn());
//        totalArea += itf.GetArea();
//        totalVolumn += itf.GetVolumn();

//        Console.WriteLine("Total Area={0}, Total Volumn={1}", totalArea, totalVolumn);
//    }
//}
#endregion







