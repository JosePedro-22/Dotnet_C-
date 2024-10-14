using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedade_C__.Net.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            foreach(Pessoa alunos in Alunos){
                Console.WriteLine(alunos.Nome);
            }
        }
    }
}