using Lab7._0;

partial class Program
{
    static void Main(string[] args)
    {
        Worker person = new Worker(1, "фыв",123,234, "апр") ;

        void asd ()
        {



            //Console.WriteLine("Укажите id");
            //person.Id = Convert.ToInt32(Console.ReadLine());
            //person.DateTimeAdd = DateTime.Now;
            //Console.WriteLine("Укажите FIO");
            //person.FIO = Console.ReadLine();
            //Console.WriteLine("Укажите возраст");
            //person.Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Укажите рост");
            //person.Rise = Convert.ToDouble(Console.ReadLine());
            //person.DateBirthday = new DateOnly(2022, 1, 6);
            //Console.WriteLine("Укажите место рождения");
            //person.Сountry = Convert.ToString(Console.ReadLine());


            //var dd = Convert.ToInt32(Console.Read());
            //var mm = Convert.ToInt32(Console.Read());
            //var gggg = Convert.ToInt32(Console.Read());

            //int[] mas = new int[3];
            //for (int i = 0; i <= 2; i++)
            //{
            //    switch (i)
            //    {

            //        case 0:
            //            Console.WriteLine("Укажите день");
            //            mas[i] = Convert.ToInt32(Console.ReadLine());
            //            break;

            //        case 1:
            //            Console.WriteLine("Укажите месяц");
            //            mas[i] = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 2:
            //            Console.WriteLine("Укажите год");
            //            mas[i] = Convert.ToInt32(Console.ReadLine());
            //            break;
            //    }
            //}

            //foreach (int i in mas)
            //{
            //    Console.Write($"{i} ");
            //}
        } // Тестовая лабуда по формированию даты

        Console.WriteLine(person.Print());
        Console.ReadKey();

        Repository1 repository1 = new Repository1(
            new Worker (1, "Duck Luck Nuck", 166, 36, "Москва"),
            new Worker(2, "Ваилий Пека", 146, 13, "Питер"),
            new Worker(3, "Дмитрий Торка", 156, 14, "Лондон"),
            new Worker(4, "Станислав Бочка", 177, 32, "Париж")
            );

        Console.WriteLine(repository1[0].Print());
        Console.ReadKey();

    }
}