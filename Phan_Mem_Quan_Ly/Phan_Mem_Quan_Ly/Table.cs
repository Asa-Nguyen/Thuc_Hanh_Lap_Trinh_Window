using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phan_Mem_Quan_Ly
{
    internal class Table
    {
        public int id_table;
        public string name_table;
        public Table(int id_table,string name_table) {
            this.id_table = id_table;
            this.name_table = name_table;
        }
    }
}
