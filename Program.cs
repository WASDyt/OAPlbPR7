////Задание 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        string line = Console.ReadLine(); //исходная строка
//        HashSet<char> setLine = TranslateLineToSet(line); //множество символов исходной строки
//        PrintSet(setLine);
//        HashSet<char> setDigit = new HashSet<char> { 'T', 'U', 'V', 'V', 'W', 'X', ',', '.', '!', ';', ':', ',', };// множество символов, которые нужно найти
//        PrintSet(setDigit);
//        HashSet<char> newSet = setLine; // копия исходного множества
//        newSet.IntersectWith(setDigit); //пересечение 
//        PrintSet(newSet);
//        Console.ReadKey();
//    }
//    private static HashSet<char> TranslateLineToSet(string word)
//    {
//        HashSet<char> setWord = new HashSet<char>();
//        foreach (char c in word)
//        {
//            setWord.Add(c);
//        }
//        return setWord;
//    }
//    private static void PrintSet(HashSet<char> set)
//    {
//        foreach (char c in set)
//        {
//            Console.Write($"{c} ");
//        }
//        Console.WriteLine();
//    }
//}

//Задание 2
Console.WriteLine("Задание 2");
string[] allList = {"Globeflower","Wisteria","Scilla","Lilac","Camellia",
                "Mock Orange","Nicotiana", "Morning Glory","Loosestrife","Delphinium"};
string[] list1 = { "Globeflower", "Wisteria", "Morning Glory", "Loosestrife" };
string[] list2 = { "Mock Orange", "Nicotiana", "Morning Glory", "Delphinium" };
string[] list3 = { "Wisteria", "Scilla", "Lilac", "Morning Glory" };
string[] list4 = { "Wisteria", "Lilac", "Mock Orange", "Morning Glory" };
string[] list5 = { "Nicotiana", "Morning Glory" };
PrintSet(allList);
PrintSet(list1);
PrintSet(list2);
PrintSet(list3);
PrintSet(list4);
PrintSet(list5);

Console.WriteLine("Входит во все множества:");
PrintSet(list1.Intersect(list2).Intersect(list3).Intersect(list4).Intersect(list5));

Console.WriteLine("НЕ входит ни в одно множества:");
PrintSet(allList.Except(list1).Except(list2).Except(list3).Except(list4).Except(list5));

Console.WriteLine("Входят во второе множество, но их нет в четвертом:");
PrintSet(list2.Except(list4));


static void PrintSet(IEnumerable<string> set)
{
    foreach (string c in set)
    {
        Console.Write($"{c} ");
    }
    Console.WriteLine();
}
