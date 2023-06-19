using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class FacultyTypedEnumerator : IEnumerator<Faculty>
    {
        private List<Faculty> faculties;
        private int position = -1;
        public FacultyTypedEnumerator(List<Faculty> faculties) => this.faculties = faculties;
        public Faculty Current
        {
            get
            {
                if (position == -1 || position >= faculties.Count)
                {
                    throw new ArgumentException();
                }
                return faculties[position];
            }
        }
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            if (position < faculties.Count - 1)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset() => position = -1;
        public void Dispose() { }
    }
}
