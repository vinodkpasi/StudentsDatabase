using StudentsManager;
using System;
namespace Test
{
    public class DataResult
    {
        public Student Data;
        public string ErrorMessage;

        public DataResult Add(Student student)
        {
            try
            {
                Data = Students.Add(student);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return this;
        }

        public DataResult GetById(int id)
        {
            try
            {
                Data = Students.GetById(id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return this;
        }
    }
}
