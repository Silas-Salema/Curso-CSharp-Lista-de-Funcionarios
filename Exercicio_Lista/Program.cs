using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();
            Console.Write("Quantos funcionários serão registrados?:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário: #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario { Id = id, Nome = nome, Salario = salario });
            }

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.Write("Informe o Id do funcionário que receberá o aumento: ");
            int pesquisaId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.Id == pesquisaId);
            
            if (func == null)
            {
                Console.WriteLine("Este id não existe");
            }
            else
            {
                Console.Write("Entre com a porcetagem do aumento:");
                double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.IncrementaSalario(aumento);
            }

            Console.WriteLine("Atualização da lista de funcionários: ");
            foreach(Funcionario obj in list) {
                Console.WriteLine(obj);
            }
            
            
        }
    }
}
