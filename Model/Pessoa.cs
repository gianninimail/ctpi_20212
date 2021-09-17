using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public Int64 CPF { get; set; }

        public String Nome { get; set; }

        public String Email { get; set; }

        public String Cel { get; set; }

        public DateTime Nascimento { get; set; }

        public String Profissão { get; set; }

        public String Sexo { get; set; }

        public String EstadoCivil { get; set; }

        public Boolean Filhos { get; set; }

        public Boolean Animais { get; set; }

        public Boolean Fumante { get; set; }

        public Endereco Endereco { get; set; }
    }
}
