using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsManager
{
    public static class Students
    { 
        static List<Student> students;
        static Students()
        {
            students = new List<Student>();
        }

        public static Student Add(Student student)
        {
            //Auto increment the Id
            student.Id = students.Count + 1;

            //Verify duplicate student name
            if (students.Where(p => p.Name == student.Name).ToList().Count > 0)
                throw new Exception("Student record with same name already exists.");

            students.Add(student);
           
            return student;
        }

        public static Student GetById(int id)
        {
            Student student = students.Where(p => p.Id == id).FirstOrDefault();

            //Verify student exsits.
            if (student==null)
                throw new Exception("No record found.");
            
            return student;
        }

        public static void RemoveById(int id)
        {
          students.RemoveAll(p => p.Id == id);
        }

        public static void RemoveByName(string name)
        {
            students.RemoveAll(p => p.Name == name);
        }

        public static void ClearAll() 
        {
            students.Clear();
        }
    }
}
