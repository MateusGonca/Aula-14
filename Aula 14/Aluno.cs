using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14
{
    public class Aluno
    {
        public int RA { get; set; }
        public string Nome { get; set; }
        public string Turma { get; set; }
        public string CPF { get; set; } 

        public Aluno (int ra, string n, string t, string c)
        {
            this.RA = ra;
            this.Nome = n;
            this.Turma = t;
            this.CPF = c;
        }
    }
}
