﻿//Zadanie1

using PO.lab02;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=======================Zad01=====================\n\n");
        Person person1 = new Person("Adam", "Miś", new DateTime(1990, 3, 20, 12, 30, 10)); 
        Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 3, 5, 12345); 
        Person person3 = new Player("Robert", "Lewandowski", new DateTime(1988, 10, 3), "Striker", "Bayern", 41); 
        person1.Details(); 
        person2.Details(); 
        person3.Details(); 
        Student student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 29), 2, 5, 54321); 
        student.Details(); 
        ((Player)person3).ScoreGoal(); 
        person3.Details();

        Console.WriteLine("\n\n=======================Zad02=====================\n\n");
        ((Student)person2).AddGrade("PO", 5.0D, new DateTime(2011, 2, 20)); 
        ((Student)person2).AddGrade("Bazy Danych", 5.0D, new DateTime(2011, 2, 13)); 
        person2.Details(); 
        Grade grade = new Grade("Bazy Danych", 5.0D, new DateTime(2011, 5, 1)); 
        student.AddGrade(grade); 
        student.AddGrade("AWWW", 5.0D, new DateTime(2011, 5, 11)); 
        student.AddGrade("AWWW", 4.5D, new DateTime(2011, 4, 2)); 
        student.Details();
        student.DeleteGrade("AWWW", 4.5D, new DateTime(2011, 4, 2)); 
        student.Details(); 
        student.DeleteGrades("AWWW"); 
        student.Details(); 
        student.AddGrade("AWWW", 5.0D, new DateTime(2011, 4, 3)); 
        student.DeleteGrades(); 
        student.Details();

        Console.WriteLine("\n\n=======================Zad03=====================\n\n");
        Person footballPlayer = new FootBallPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "striker", "FC Barcelona", 10); 
        Person handballPlayer = new HandBallPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "striker", "FC Bayern"); 
        footballPlayer.Details(); 
        handballPlayer.Details(); 
        ((Player)handballPlayer).ScoreGoal(); // rzutowanie bezpośrednie
        (footballPlayer as Player).ScoreGoal(); // rzutowanie referencyjne
        footballPlayer.Details(); 
        handballPlayer.Details();
    }
}