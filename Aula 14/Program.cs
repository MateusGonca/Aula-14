using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manipula arquivo = new Manipula();
            Aluno a = new Aluno(6322079, "Ana Beatriz",
                "3° ADS", "655.432.267-98");
            arquivo.Gravar(a.RA + ";" + a.Nome + "; " + a.Turma + "; " + a.CPF);

            List<Aluno> alunos = arquivo.Ler();
            string texto = null;
            foreach(Aluno fulano in alunos)
            {
                texto += "\nRa =" + fulano.RA + " - Nome = " + fulano.Nome + 
                    " - Curso +" + fulano.Turma + " - CPF =" + fulano.CPF; 
            }
            a = new Aluno(6322079, "Ana Beatriz",
                "3° ADM", "655.432.267-98");
            arquivo.Alterar(a);

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
