using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS1
{
    internal class employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public double salary {  get; set; }
        public override string ToString()
        {
            return $"ID :{ID} , NAme: {Name} , Salary :{salary}";
        }
    }
}
