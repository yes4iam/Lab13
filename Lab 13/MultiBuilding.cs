using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class MultiBuilding:Building
    {
        int floors;
        public MultiBuilding(string adress, int length, int width, int height, int floors)
            :base(adress,length,width,height)
        {
            this.floors = floors;
        }
        public string Info()
        {
            string result = base.Info();
            result += $", этажей: {floors}";
            return result;
        }
    }
}
