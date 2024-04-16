using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaAnketa
{
    public class Person
    {
        private string name;
        private string gender;
        private string eyas;
        private string hair;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Eyas
        {
            get { return eyas; }
            set { eyas = value; }
        }
        public string Hair
        {
            get { return hair; }
            set { hair = value; }
        }
    }
 
    


}
