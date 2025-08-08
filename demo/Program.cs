namespace Tasks
{

    internal class Program
    {
        #region Task 01 
        internal class BananaRipenessRange<T> where T : struct, IComparable<T>
        {
            public T Min { get; set; }
            public T Max { get; set; }


            public bool IsPerfectBanana(T ripeness)
            {
                if (ripeness.CompareTo(Min) >= 0 && ripeness.CompareTo(Max) <= 0)
                    return true;
                return false;
            }



            public BananaRipenessRange(T min, T max)
            {
                if (typeof(T) != typeof(int) && typeof(T) != typeof(float))
                    throw new ArgumentException("T must be int or float only.");

                Min = min;
                Max = max;
            }
        }
        #endregion

        #region Task 02
        internal class MultiBox<T>
        {
            List<T> list = new List<T>();

            public void InsertItem(T item)
            {
                list.Add(item);
            }
            public List<T> GetAllItems()
            {
                return list;
            }
            public int Count()
            {
                return list.Count;
            }
            public bool IsEmpty()
            {
                return list.Count == 0;
            }
        }
        #endregion


        static void Main(string[] args)
        {
            #region Task 01
            //BananaRipenessRange<int> bananaRange = new BananaRipenessRange<int>(5, 8);

            //Console.WriteLine(bananaRange.IsPerfectBanana(7)); // True
            //Console.WriteLine(bananaRange.IsPerfectBanana(3)); // False 
            #endregion

            #region Task 02
            //MultiBox<string> stringbox = new MultiBox<string>();
            //Console.WriteLine(stringbox.IsEmpty());

            //stringbox.InsertItem("mohamed");
            //stringbox.InsertItem("Ahmed");

            //Console.WriteLine( stringbox.Count()); 
            #endregion
        }
    }
}
