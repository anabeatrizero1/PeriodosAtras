using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras.ConsoleApp
{
    public class PeriodoDeTempo
    {
        int anos = 0;
        int meses = 0;
        int semanas = 0;
        int dias = 0;

        DateTime data;

        public void RecebeData(string data)
        {
            string[] dataSeparada = data.Split('/');

            int dia = Convert.ToInt32(dataSeparada[0]);
            int mes = Convert.ToInt32(dataSeparada[1]);
            int ano = Convert.ToInt32(dataSeparada[2]);

            this.data = new DateTime(ano, mes, dia);
        }
        public void TempoQuePassou()
        {

            DateTime dataAtual = DateTime.Now;
            TimeSpan periodoTempo = dataAtual - data;

            int dataEmDias = periodoTempo.Days;

            int resto = dataEmDias;

            if (dataEmDias > 360)
            {
                anos = dataEmDias / 360;
                resto = anos % 360;
            }
            if (resto > 30)
            {
                meses = resto / 30;
                resto = meses % 30;
            }
            if (resto >= 7)
            {
                semanas = resto / 7;
                resto = semanas % 7;
            }
            if (resto < 7)
                dias = resto;




            string resultado = ObterResultado();
            Console.WriteLine(resultado);

        }

        private string ObterResultado()
        {
            string resultado = data.ToString("dd/MM/yyyy") + " = ";

            if (anos >= 1)
            {
                resultado = resultado + anos + (anos > 1 ? " anos " : " ano ");

            }
            if (meses >= 1)
            {
                if(anos != 0)
                {
                    resultado = resultado + "e ";
                }
                resultado = resultado + meses + (meses > 1 ? " meses " : " mês ");

            }
            if (semanas >= 1)
            {
                if (meses != 0)
                {
                    resultado = resultado + "e ";
                }
                resultado = resultado + semanas + (semanas > 1 ? " semanas " : " semana ");

            }
            if (dias >= 1)
            {
                if (semanas != 0)
                {
                    resultado = resultado + "e ";
                }
                resultado = resultado + dias + (dias > 1 ? " dias " : " dia ");

            }

            return resultado + "atrás";
        }


    }
   

}
