using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3x_1
{
    public class Line(int id, int peak, int length, List<int>nodes)
    {
        public int Id { get; set; } = id;
        public int Peak { get; set; } = peak;
        public  int Length { get; set; } = length;
        public  List<int> Nodes { get; set; } = nodes;


    }
}

