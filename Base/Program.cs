using System;

namespace Base
{
     public interface IArea
    {
        public void area();
       
    }
    public interface IDraw
    {
        public void draw();
    }
    
   
  public class Shape
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        //  public Shape()
        //{

        //}

        //  public Shape(int width , int height)
        // {
        //   Width = width;
        // Height = height;
        //}
       // public override string ToString()
       // {
       //     return $"{nameof(Width)}: {Width} , {nameof(Height)} : {Height}";
       // }

    }
    public class Square : Shape , IDraw , IArea
    {
       public Square(int Side)
        {
            Width = Side;
            Height = Side;
        }
       
        public void draw()
        {
            Console.WriteLine("Square is drawn");
        }
        public void area()
        {
            int ar = Width * Height;
            Console.WriteLine(ar);
        }

    }
    public class Rectangle : Shape , IDraw , IArea
    {
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public void draw()
        {
            Console.WriteLine("rectangle is drawn");
        }
         public void area()
        {
            int ar = Width * Height;
            Console.WriteLine(ar);
        }
    }
    public class ExecuteArea
    {
        IArea _area;
        IDraw _draw;
        public  ExecuteArea(IArea aarea)
        {
            _area = aarea;
        }
        public void action()
        {
            _area.area();
        }
        
        
    }
    


        public class Program
        {

            static void Main(string[] args)
            {


                var disp = new ExecuteArea(new Rectangle(8, 9));
                disp.action();
                
                
                
                


                //var ExecuteArea = new ExecuteArea(new Square(5));
               // ExecuteArea.action();






            }
        }
    }
