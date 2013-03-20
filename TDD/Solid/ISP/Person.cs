using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public DateTime Birthday { get; private set; }
}

public class Calendar
{
    public void AddBirthday(Person person)
    {
        int age = person.Age;
        string name = person.Name;
        DateTime date = person.Birthday; 
    }


    // obeys ISP
    public void AddBirthday(string Name, DateTime birthday, int age)
    {
    }
}
