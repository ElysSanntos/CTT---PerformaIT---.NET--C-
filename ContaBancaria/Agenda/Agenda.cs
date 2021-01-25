using System;
using System.Globalization;
using System.Threading;


namespace Manicure
{
    public class Agenda

    {
        public int dia { get; set; }
        public int mes { get; set; }
        public int ano { get; set; }
        public int hora1 { get; set; }
        public int hora2 { get; set; }
        public int minuto { get; set; }
        public int cliente { get; set; }
        


        public string relacionamento;
        //DateTime horaInicial = new DateTime(2020, 8, 1, 0, 0, 0);
        //DateTime horaFinal = new DateTime(2020, 8, 1, 12, 0, 0);
        //string resultado = DateTime.Compare(hora1, hora2);

              
      
       
        public static bool ValidaHora(string maskhora)
        {
            String hora = "";
            String[] hms = hora.Split(":");
            int horas = int.Parse(hms[0]);
            int segundos = int.Parse(hms[2]);
            int minutos = int.Parse(hms[1]);
            if (horas > 24)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
