using System;

Person[] arr = new Person[5];
for (int i = 0; i <= 4; i++)
{
    Console.WriteLine("Введите фамилию");
    string a = Console.ReadLine();
    Console.WriteLine("Введите инициалы");
    string b = Console.ReadLine();
    Console.WriteLine("Введите должность");
    string c = Console.ReadLine();
    Console.WriteLine("Введите год поступления на работу");
    int d = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите зарплату");
    int e = Convert.ToInt32(Console.ReadLine());
    arr[i] = new Person(a, b, c, d, e);
}
one(arr);
two(arr);

void one(Person[] a)
{
    Console.WriteLine("Введите минимальную зарплату-1");
    int f = Convert.ToInt32(Console.ReadLine());
    foreach (Person i in a)
    {
        if (i.pay > f)
        {
            Console.WriteLine(i.name + i.ini);
        }
    }
}
void two(Person[] a)
{
    Console.WriteLine("Введите должность");
    string t = Console.ReadLine();
    foreach (Person i in a)
    {
        if (i.job == t)
        {
            Console.WriteLine(i.name + i.ini);
        }
    }
}
class Person
{
    public string name;
    public string ini;
    public string job;
    public int year;
    public int pay;
    public Person(string nam, string inis, string jo, int yea, int pa)
    {
        name = nam;
        ini = inis;
        job = jo;
        year = yea;
        pay = pa;
    }
}