using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace propriedade_C__.Net.Models
{
    public class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string nome, int Idade){}
        private string _nome;
        public string Nome { 
            get => _nome.ToUpper();
            set {
                if(value == "") 
                    throw new ArgumentNullException("O nome nao pode ser vazio");
                _nome = value;
            } 
        }
        public int Idade { get; set; }

        public void Apresentar(){
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}