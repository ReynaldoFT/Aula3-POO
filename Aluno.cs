using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Aluno 
    {
        // Declaração de Atributo

        string nome;
        string cpf;
        string endereco;
        int ra;

        // Declaração de Método setter e getter (Set e Get)

        public void SetNome(string nome)
        {
            this.nome = nome; // "this" refêrencia ao próprio objeto da classe
        }
        public string GetNome()
        {
            return this.nome; // retorna o valor 
        }
        public void SetCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string GetCpf()
        {
            return this.cpf;
        }
        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public string GetEndereco()
        {
            return this.endereco;
        }
        public void SetRa(int ra)
        {
            this.ra = ra;
        }
        public int GetRa()
        {
            return this.ra;
        }




    }
}
