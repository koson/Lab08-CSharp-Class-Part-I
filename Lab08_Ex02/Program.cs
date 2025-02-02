// See https://aka.ms/new-console-template for more information
using System;

class Person
{
    public string Name { get; set; }
    public string Id { get; set; }
    public int Income { get; set; }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Rambo";
        p.Id = "1987";
        p.Income = 2500;

        // แสดงชนิดของอ็อบเจ็กต์และชนิดของตัวแปร
        Console.WriteLine($"Type of p is {p.GetType()}");
        Console.WriteLine($"p.Name = {p.Name}\ttype = {p.Name.GetType()}");
        Console.WriteLine($"p.Id = {p.Id}\ttype = {p.Id.GetType()}");
        Console.WriteLine($"p.Income = {p.Income}\ttype = {p.Income.GetType()}");
    }
}

