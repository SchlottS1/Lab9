using System;

class Employee {

  public string firstname;
  public string lastname;
  public string id;
  public int age;
  public string address;
  public string phonenumber;
  public string title;
  public double yearlysalary;
  public string employmentstatus;

  public Employee()
  {
    firstname = "Unknown";
    lastname = "Unknown";
    id = "Unknown";
    age = 0;
    employmentstatus = "active";
  }
  public Employee(string employfirstname, string employlastname, string employid, int employage, string employemploymentstatus)
  {
   firstname = employfirstname;
   lastname = employlastname;
   id = employid;
   age =  employage;
   employmentstatus = employemploymentstatus;
  }

  public void Intro()
  {
    Console.WriteLine("First name: " + firstname);
    Console.WriteLine("Last Name: " + lastname);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Employment Status: " + employmentstatus);
  }

}