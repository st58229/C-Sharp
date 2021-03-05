using System;
using System.Collections.Generic;
using System.Text;

namespace fei
{
    class StudentsTable
    {
        public Students Students { get; set; } = new Students();

        private delegate int GiveMeKey(Student student);

        public static int FindKey(Student student)
        {
            return student.Id;            
        }

        GiveMeKey kk = FindKey;

        public Student FindStudent(int key)
        {
            return null;            
        }

    }
}
