using System;
namespace StudentDBAppnew
{
	public class Student
	{
        //id
        //name
        //email

        private static int statId; //default = 0


        public int Id { get; set; }

        public String Name { get; set; }


        public String Email { get; set; }



        public Student(String name, String email)
        {
            Id = ++statId;
            Name = name;
            Email = email;
        }
    }
}

