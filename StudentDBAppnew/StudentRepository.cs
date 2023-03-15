using System;
namespace StudentDBAppnew
{
	public class StudentRepository
	{
        private static List<Student> students = new List<Student>();


        public static void initlizeList()
        {
            Student s1 = new Student("Dana", "d@gmail.com");//1
            Student s2 = new Student("Aana", "a@gmail.com");//2
            Student s3 = new Student("Sutha", "S@gmail.com");//3

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
        }

        //return list

        public static List<Student> GetStudents()
        {
            initlizeList();

            return students;
        }




        //add to the list

        public static void addStudent(Student s)
        {
            students.Add(s);

        }


        //search the list
        public static Student GetStudentById(int id)
        {
            foreach (Student s in students)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return null;
        }
    }
}

