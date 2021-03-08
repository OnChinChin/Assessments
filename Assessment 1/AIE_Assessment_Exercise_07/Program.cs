/*
 * Appendix 4 - Exercise 1: Greetings
 */

using System;
using System.Collections.Generic;

namespace AIE_Assessment_Exercise_07
{
    class Program
    {
        class Person
        {
            public string name = "";
            public int phone = 0;
            public string email = "";
            
            

            public Person(string name, int phone, string email)
            {
                this.name = name;
                this.phone = phone;
                this.email = email;
                
            }

            public virtual void SayGreeting()
            {
                Console.WriteLine("Hello, I'm " + name);
            }

        }

        class Doctor : Person
        {
            public int salary = 0;

            public Doctor(string name, int phone, string email, int salary) : base(name, phone, email)
            {
                this.salary = salary;
            }
            
           
            public override void SayGreeting()
            {
                Console.WriteLine("Hello, I'm Dr." + name);
            }
        }

        static void Main(string[] args)
        {
            // TODO:
            // Create instances of
            // - A Person and Doctor classes.

            Person p1 = new Person("bob", 123457, "bob@gmail");
            Doctor p2 = new Doctor("fred", 38756347, "fred@gmail", 3131231);
            Doctor p3 = new Doctor("ted",823648, "ted@gmail", 1231231);
            Person p4 = new Person("Calvin", 234234, "Calvin@gmail");
            // Invoke the "SayGreeting" method on the above instances
            p1.SayGreeting(); // hello i'm bob
            p2.SayGreeting(); // hello i'm dr. fred
            p3.SayGreeting(); // hello i'm dr. ted
            p4.SayGreeting();
        }
    }
}
