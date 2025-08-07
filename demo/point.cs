using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Point : IComparable<Point>
    {
        int X;
        int Y;

        public Point(  int x ,   int y)
        {
            X = x; Y = y;
        }



        //public int CompareTo(object? obj)
        //{
        //    Point P = (Point) obj;
        //    if (X == P.X)
        //        return Y.CompareTo(P.Y);
        //    return X.CompareTo(P.X);
        //}

        // when use CompareTo to ignore obj is a null or any datatype exepet int
        //must be use:

        //1. is conditional operator (With Class or struct)

        //public int CompareTo(object? obj)
        //{
        //    if(obj is not null)
        //    {
        //        if(obj is Point P)
        //        {
        //            //Point P = (Point)obj;
        //            if (X == P.X)
        //                return Y.CompareTo(P.Y);
        //            return X.CompareTo(P.X);
        //        }
        //    }

        //    return 1;
        //}


        //2.As casting operator (With Class Only)


        //public int CompareTo(object? obj)
        //{
        //    Point P = obj as Point;
        //    if (obj is not null)
        //    {
        //            if (X == P.X) return Y.CompareTo(P.Y);
        //            return X.CompareTo(P.X);
        //    }
        //    return 1;
        //}

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                    if (X == other.X) return Y.CompareTo(other.Y);
                    return X.CompareTo(other.X);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"(X: {X} , Y: {Y})";
        }
    }
}
