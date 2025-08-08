namespace Assignment
{
    internal class Program
    {
        #region Q01

        internal class Range<T> where T : IComparable<T>
        {
            private T Max, Min;

            public bool IsInRange(T value)
            {
                return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
            }

            public double Length()
            {
                try
                {
                    double maxVal = Convert.ToDouble(Max);
                    double minVal = Convert.ToDouble(Min);
                    return maxVal - minVal;
                }
                catch
                {
                    throw new InvalidOperationException("Type T must be convertible to double to calculate Length.");
                }

            }


            public Range(T max, T min)
            { Max = max; Min = min; }
            public override string ToString()
            { return $"Max: {Max} , Min: {Min}"; }

        }
        #endregion

        #region Q02
        public static void SWAP<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        public static void ArrayList<T>(T[] arr) where T : IComparable<T>
        {
            if (arr?.Length > 0)
            {
                int left = 0;
                int right = arr.Length - 1;
                while (left < right)
                {
                    SWAP(ref arr[left], ref arr[right]);
                    left++;
                    right--;
                }
            }
        }
        #endregion

        #region Q03
        public static List<int> GetEvenNumbers(List<int> arr)
        {
            List<int> values = new List<int>();

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    values.Add(i);
                }
            }
            return values;
        }
        #endregion

        #region Q04

        internal class FixedSizeList<T>
        {
            public int Capacity, count = 0;


            List<T> values = new List<T>();

            public void Add(T n)
            {
                if (count < Capacity)
                {
                    values.Add(n);
                    count++;
                }
                else
                {
                    throw new InvalidOperationException("List is full. Cannot add more items.");
                }

            }

            public T Get(int n)
            {
                if (n >= 0 && n < count)
                {
                    return values[n];
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

            }

            public FixedSizeList(int capacity)
            { Capacity = capacity; }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q01
            //Range<int> range = new Range<int>(30, 20);

            //Console.WriteLine(range);  

            //Console.WriteLine(range.IsInRange(25));  // true
            //Console.WriteLine(range.IsInRange(35));  // false

            //Console.WriteLine("Length: " + range.Length()); 
            #endregion

            #region Q02
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Before Reverse:");
            //foreach (var n in numbers)
            //    Console.Write(n + " ");

            //ArrayList(numbers);  

            //Console.WriteLine("\nAfter Reverse:");
            //foreach (var n in numbers)
            //    Console.Write(n + " "); 
            #endregion

            #region Q03
            //List<int> input = new List<int> { 1, 2, 3, 4, 5, 6 };
            //List<int> result = GetEvenNumbers(input);

            //foreach (int num in result)
            //{
            //    Console.Write(num + " ");
            //} 
            #endregion

            #region Q04
            //FixedSizeList<string> list = new FixedSizeList<string>(3);
            //list.Add("One");
            //list.Add("Two");
            //list.Add("Three");

            //Console.WriteLine(list.Get(0));
            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(2));

            //try { list.Add("Four"); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            //try { Console.WriteLine(list.Get(5)); } catch (Exception ex) { Console.WriteLine(ex.Message); } 
            #endregion


        }
    }
}
