using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Faculty
    {
        private string _name;
        private List<Student> _facultyStudents =  new List<Student>();

        public Faculty (string name)
        {
            if (name != null && name.StartsWith("Ф")) _name = name;
            else _name = "ФАК";
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null && value.StartsWith("Ф")) _name = value;
            }
        }
        public void AddStudent (Student student)
        {
            if (student != null) _facultyStudents.Add(student);
        }
        public bool RemoveStudent (Student student)
        {
            if (student != null) return _facultyStudents.Remove(student);
            return false;
        }

        public IEnumerator GetEnumerator() => _facultyStudents.GetEnumerator();
        public IEnumerable GetPersonnel(int max)
        {
            for (int i = 0; i < max; i++)
            {
                if (i == personnel.Length)
                {
                    yield break;
                }
                else
                {
                    yield return personnel[i];
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _facultyStudents.Count; i++)
            {
                yield return _facultyStudents[i];
            }
        }
    }
}
