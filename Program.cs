using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarção e instânciaçãao dos objetos

            Aluno al = new Aluno();
            Mensalidade men = new Mensalidade();
            // Declaração      =   Instânciação

            // Chamada dos métodos

            Console.Write("Digite o nome: ");
            al.SetNome(Console.ReadLine());          // "Set" é para receber um valor
            Console.Write("Digite o endereço: ");
            al.SetEndereco(Console.ReadLine());
            Console.Write("Digite o CPF: ");
            al.SetCpf(Console.ReadLine());
            Console.Write("Digite o RA: ");
            al.SetRa(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite o Curso: ");
            men.SetCurso(Console.ReadLine());
            Console.Write("Digite o valor: ");
            men.SetValor(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Digite o dia do pagamento: ");
            men.SetDia(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("\nDados do Aluno");
            Console.WriteLine("Ra:" + al.GetRa() + "\nAluno: " + al.GetNome());
            Console.WriteLine("Endereço: " + al.GetEndereco() + "\nCPF: " + al.GetCpf());
            Console.WriteLine("Curso: " + men.GetCurso() + "\nValor da mensalidade: " + men.GetValor().ToString("C") +
                              "\nValor a pagar: " + men.Calcular().ToString("C"));


            Console.ReadKey();
        }
    }
}
