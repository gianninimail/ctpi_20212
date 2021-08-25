using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Class1
    {
        public Int32 Id { get; set; }
 
        public String getNome {
            get;
            set; 
        }

        public Int32 getId()
        {
            return this.Id + 1;
        }

    }
}
