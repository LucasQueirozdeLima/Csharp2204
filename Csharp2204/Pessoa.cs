using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2204
{
    class Pessoa
    {
        /*public int participantes;
        public void cadastrar() 
        {
            for(int i = 0; i < participantes - 1; i++)
            {
                nn ligar para isso
            }
        }*/

        private string nome;
        private double salario;

        public double Salario { //propriedade
            get
            {
                return this.salario;
            }
            set 
            {
                if (this.salario > value)
                {
                    Console.WriteLine("Salario atual menor que o informado");
                }
                else
                {
                    this.salario = value;
                    Console.WriteLine("Salario atualizado");
                }
            } 
        }
        

        public Pessoa(string nome, double salario) // Metodo contrutor
        {
            this.nome = nome;
            this.salario = 1000;
        }

        public string Nome { //propriedade
            get
            { 
                return this.nome.ToUpper(); 
            }

            set 
            {
                this.nome = value;
            }
        }
        public Pessoa() { }
        public string Email { get; set; } //propriedade
    }
}
