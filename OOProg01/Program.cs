// See https://aka.ms/new-console-template for more information
using OOProg01;

Console.WriteLine("Hello,OO World!");


Human h1 = new Human();

h1.Name = "Peter";
h1.Height = 180;
h1.Weight = 80;

Console.WriteLine(h1.Name);
string theName = h1.Name;
Console.WriteLine($" Personen {theName} har et BMI på {h1.BMI} ");

double bmi = h1.BMI;
Console.WriteLine(bmi);
Human h2 = new Human();
h2.Name = "Lars";
h2.Height = 170;
h2.Weight = 70;
Console.WriteLine($" Personen {h2.Name} har et BMI på {h2.BMI} ");


Student student = new Student("John", 1, 1, "01/01/2000", "123 Main St", "123-456-7890", "test@zealand.dk");
student.PrintInfo();

Student student2 = new Student("Jane", 2, 2, "02/02/2000", "456 Main St", "123-456-7890", "test2@zealand.dk");

student2.PrintInfo();
