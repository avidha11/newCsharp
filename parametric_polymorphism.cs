class Program
    {

        static void Main(string[] args)
        {
            //Implicitly Typed Variabel
            var names = new string[] { "india", "Sachin", "ThinkPad", "Hexa" };
            int[] numbers = new int[] { 100, 3445, 677, 8, 90, 78 };
 
           List<int> _numberList= Filter<int>(numbers, (int item) => { return item > 1000; });
 
           List<string> _resultList= FilterString(names,CheckStringEndsWithAny("a"));
 
            for(int i = 0; i < _resultList.Count; i++)
            {
                Console.WriteLine(_resultList[i]);
            }
            _resultList = FilterString(names,CheckStringEndsWithAny("n"));
 
            for (int i = 0; i < _resultList.Count; i++)
            {
                Console.WriteLine(_resultList[i]);
            }
            _resultList = FilterString(names,CheckStringEndsWithAny("d"));
 
            for (int i = 0; i < _resultList.Count; i++)
            {
                Console.WriteLine(_resultList[i]);
            }
            _resultList = FilterString(names,new Func<string, bool>(CheckStringLengthGreaterThanOrEqualTo(5));
 
            for (int i = 0; i < _resultList.Count; i++)
            {
                Console.WriteLine(_resultList[i]);
            }
        }
        
        static Func<string,bool> CheckStringEndsWithAny(string endsWith)
        {
 
            return (string item) => { return item.EndsWith(endsWith); };

        }
        static Func<string,bool> CheckStringLengthGreaterThanOrEqualTo(int length)
        {
            return (string item) => { return item.Length >= length; };
        }
        static List<string> FilterString(string[] source,Func<string,bool> predicate)
        {
            //steps
            List<string> _resultList = new List<string>();
 
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate.Invoke(source[i]))
                {
                    _resultList.Add(source[i]);
                }
            }
            return _resultList;
        }
        static List<T> Filter<T>(T[] source, Func<T, bool> predicate)
        {
            //steps
            List<T> _resultList = new List<T>();
 
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate.Invoke(source[i]))
                {
                    _resultList.Add(source[i]);
                }
            }
            return _resultList;
        }
    }
