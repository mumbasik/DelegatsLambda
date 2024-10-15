namespace DelegatsLambda
{

    delegate void MyArray(int[] arr);
    delegate void Date();



    class Arr
    {
        

        public void Parn(int[] arr)
        {
            Console.WriteLine("Парные числа:");
            foreach (var i in arr) 
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void NeParn(int[] arr)
        {
            Console.WriteLine("Непарные числа:");
            foreach (var i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void SimplNumb(int[] arr)
        {
            Console.WriteLine("Простые числа:");
            for ( int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % arr[i] == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        public void Fibanachi(int[] arr)
        {
           
            
                arr[0] = 0;
                arr[1] = 1;
            

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine("Числа Фибоначчи:");
            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }
    }

    class Datee
    {
        public void CurrentTime()
        {
            DateTime currentTime = DateTime.Now;

            
            Console.WriteLine("Текущее время: " + currentTime.ToString("HH:mm:ss"));
        }
        public void CurrentData()
        {
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("Текущая дата: " + currentDateTime.ToString("dd.MM.yyyy"));

        }
        public void DayOfWeek()
        {
            DateTime currentDateTime = DateTime.Now;

            
            DayOfWeek dayOfWeek = currentDateTime.DayOfWeek;

            
            Console.WriteLine("Сегодня: " + dayOfWeek);
        }
        public void Triangle()
        {
            int h = 5;
            int a = 6;
            double S = (1 / 2) * (h * a);
            Console.WriteLine("Result of Triangle: " + S);
        }
        public void Rectangle()
        {
            int a = 9;
            int b = 10;
            Console.WriteLine("Result of Rectangle: " + a * b);
        }
    }

   

    internal class Program
    {
        static void Main(string[] args)
        {
            Arr obj = new Arr();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyArray del = obj.Parn;
            del(arr);
            MyArray del2 = obj.NeParn;
            del2(arr);
            MyArray del3 = obj.SimplNumb;
            del3(arr);
            MyArray del4 = obj.Fibanachi;
            del4(arr);
            Datee datee = new Datee();
            Date d = datee.CurrentTime;
            d();
            Date e = datee.CurrentData;
            e();
            Date w = datee.DayOfWeek;
            w();
            Date o = datee.Triangle;
            o();
            Date v = datee.Rectangle;
            v();
            //3
            string name = "Andrey";
            string[] arrrr = { "Andrey", "Anna", "Vanya" };
            var result = arrrr.Where(word => word.Equals(name)).ToArray();
            Console.WriteLine("Результат: ");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
            //N4
            Console.WriteLine("Число кратное семи");
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var res = ar.Count(x => x % 7 == 0);
            Console.WriteLine(res);
            //N5
            var r = ar.Count(x => x > 0);
            Console.WriteLine("Позитивные числа");
            foreach(var x in ar)
            {
                Console.WriteLine($"{x}");
            }
            //N6
            
            int[] arrr = { -1, -2, -4, -8, -9, -4, 11, 10 };
            var uniqueNegatives = arrr.Where(x => x < 0).Distinct().ToArray();
            Console.WriteLine("Уникальные негативные числа");
            foreach(var x in arrr)
            {
                Console.WriteLine($"{x}");
            }
           

        }
    }
}
