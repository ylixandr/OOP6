//using SausageSimple;

//class Program

//{
//    // Метод - печать списка
//    public static void PrintList(List<Sausage> sgs)
//    {
//        Console.WriteLine("\nНовый список");
//        for (int i = 0; i < sgs.Count; i++) sgs[i].Info();
//        // foreach (Sausage sg in sgs) sg.Info();   // другой вариант цикла
//    }

//    public static void TheLargestMAss (List<Sausage> sausages)
//    {

//        Console.WriteLine("\n\n Метод самой большой массы");
//        double maxMass = sausages[0].Mass;
//        int a = 0;

//        for (int i = 0; i < sausages.Count; i++)
//        {
//            if (sausages[i].Mass > maxMass)
//            {
//                maxMass = sausages[i].Mass;
//                a = i;
//            }
//        }

//        sausages.Insert(0, sausages[a]);
//        sausages.RemoveAt(a+1);
//        PrintList(sausages);
//    }

//    public static void TheSmallestMassRemove (List<Sausage> sausages)
//    {
//        Console.WriteLine("\n\n Удалили самую маленькую по весу колбаску");
//        double minMass = sausages[0].Mass;
//        int b = 0;
//        for (int i = 0; i < sausages.Count; i++)
//        {
//            if (sausages[i].Mass < minMass)
//            {
//                minMass = sausages[i].Mass;
//                b = i;

//            }
//        }

//        sausages.RemoveAt(b);
//        PrintList(sausages);
//    }

//    static void PriceRemove (List<Sausage> sausages)
//    {
//        double target = 10;
//        for (int i = 0; i < sausages.Count; i++)
//        {
//            if (sausages[i].Price > target)
//            {
//                sausages.RemoveAt(i);
//            }
//        }
//        PrintList(sausages);
//    }

//    static void Main(string[] args)
//    {
//            // Ширина окна = 120 символов

//        // Создаем список для объектов типа Sausage (колбаса)
//        List<Sausage> sausages = new List<Sausage>();

//        //Создаем объект -кусок колбасы);
//        Sausage ssg1 = new Sausage("Salami", 12, 10);

//        //Убедимся, что создан объект с заданными атрибутами
//        ssg1.Info();

//        sausages.Add(ssg1);     //Добавляем объект в список
//        PrintList(sausages);    // Печать списка

//        // Добавляем еще объекты в список (чуть иначе создавая объекты - 
//        // без промежуточной переменной)

//        sausages.Add(new Sausage("Ливерная", 12.3, 23.6));
//        sausages.Add(new Sausage("Собачья радость", 7, 4));
//        sausages.Add(new Sausage("Докторская", 5, 20));
//        sausages.Add(new Sausage("Докторская1", 6, 7));
//        PrintList(sausages);

//        TheLargestMAss(sausages); //2.10
//        TheSmallestMassRemove(sausages);//2.11
//        PriceRemove(sausages); //2.12


//        sausages.Sort((x, y) => y.Mass.CompareTo(x.Mass));
//        PrintList(sausages);//2.13



//    }
//}

