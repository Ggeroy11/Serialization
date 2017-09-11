using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    
    public class Student
    {
        private string name;
        private int age;
        public string Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }


    }
}
