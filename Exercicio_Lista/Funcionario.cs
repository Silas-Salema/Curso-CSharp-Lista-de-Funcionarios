using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio_Lista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public void IncrementaSalario(double s)
        {
            Salario = Salario + Salario * (s/100);
        }
        public override string ToString()
        {
            return Id + ", "+ Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
