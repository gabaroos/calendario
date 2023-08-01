using System;

namespace ConcatenarDiasDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            DateTime data = new DateTime(ano, 1, 1);
            int diasNoAno = DateTime.IsLeapYear(ano) ? 366 : 365;

            string calendario = "Dia1,Sem1,Mes1,Dia2,Sem2,Mes2,Dia3,Sem3,Mes3,Dia4,Sem4,Mes4\n";

            var contador = 0;

            for (int i = 0; i < diasNoAno; i++)
            {
                var diaSemana = data.ToString("dddd").Replace("-feira", string.Empty);
                var mes = data.ToString("MMMM");

                if (contador < 3)
                {
                    calendario += $"{data.ToString("dd")},{char.ToUpper(diaSemana[0])}{diaSemana[1..]},{char.ToUpper(mes[0])}{mes[1..]},";

                    contador++;
                }
                else
                {
                    calendario += $"{data.ToString("dd")},{char.ToUpper(diaSemana[0])}{diaSemana[1..]},{char.ToUpper(mes[0])}{mes[1..]}\n";

                    contador = 0;
                }

                data = data.AddDays(1);
            }

            Console.WriteLine(calendario);
        }
    }
}