using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Institute
    {
        private string _name;
        private LinkedList<Faculty> _instituteFaculties = new LinkedList<Faculty>();

        public Institute(string name)
        {
            if (name != null) _name = name;
            else _name = "Деякий інститут";
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null) _name = value;
            }
        }
        public void AddFaculty(Faculty faculty)
        {
            if (faculty != null) _instituteFaculties.AddLast(faculty);
        }
        public bool RemoveFaculty(Faculty faculty)
        {
            if (faculty != null) return _instituteFaculties.Remove(faculty);
            return false;
        }
        public IEnumerator<Faculty> GetEnumerator()
        {
            foreach (Faculty faculty in _instituteFaculties)
            {
                yield return faculty;
            }
        }
    }
}
