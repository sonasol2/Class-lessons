using System;
namespace Class_lessons
{
	//public class Person
	//{
		
 //       public string name = "Undef";
 //       public int age;
 //       public Person() : this("undef") { }
 //       public Person(string name) : this(name, 18) { }
 //       public Person(string name, int age) { this.name = name; this.age = age; } //ключевое слово this здесь используется для того чтобы разграничить 
 //       // поле класса(name и age) и название параметра(name и age). короче чтобы просто было понятнее что к чему относится. Используется в том случае когда названия полей и параметров конструктора одинаковое, если разное то можно не использорвать.

 //       // также с помощь : this можно передавать значения для параметров к другому конструктору. Если к примеру при создании экземпляра
 //       // использовался второй конустрктор, то второй обратится за значениями к третьему. Причем сначала выполнится третий конустркутор и потом уже второй.

 //       // лучше всего использовать этот конструктор он более полноценный и сразу включает в сеюя дефолтные п: public Person(string name = "undef", int age = 18) {this.name = name; this.age = age;}

 //       public void PrintInfo()
 //       {
 //           Console.WriteLine($"Your name:{name}Your age is: {age}");
 //       }
 //   }
	
		class Person
	{
		string name;
		int age;
		public Person(string name, int age)
		{
			this.name = name;
			this.age = age; 
		} 

		public void Deconstruct(out string personName, out int personAge)
		{
			personName = name;
			personAge = age; 
		}
    }
}

