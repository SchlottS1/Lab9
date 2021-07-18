using System;

class Employee {

  private string firstname;
  private string lastname;
  private string id;
  private int age;
  private string address;
  private string phonenumber;
  private string title;
  private int yearlysalary;
  private string employmentstatus;

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
    Console.WriteLine("First Name: " + firstname);
    Console.WriteLine("Last Name: " + lastname);
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Age: " + age);
    Console.WriteLine("Employment Status: " + employmentstatus);
  }

}