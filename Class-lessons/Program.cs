namespace Class_lessons;
using Class_lessons;

class Program
{
    static void Main(string[] args)
    {

        Person jack = new Person(); //  конструктор 
        Person fred = new Person("Fred", 42);
        Person someone = new Person("F42");

        string personName = jack.name;
        int personAge = jack.age;
        //Console.WriteLine($"Name is {personName} Age is {personAge}");

        //jack.name = "Jack";
        //jack.age = 34;


        jack.PrintInfo();
        fred.PrintInfo();
        someone.PrintInfo();
    }
}


