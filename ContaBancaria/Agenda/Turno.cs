using System;
using System.Collections.Generic;
using System.Text;

namespace Manicure
{
    class Turno
    {
        private TurnoFunc turno;

        public DateTime EntradaManha
        {
            get { return Convert.ToDateTime("08:00"); }
            
        }
        public DateTime SaidaManha
        {
            get { return Convert.ToDateTime("17:00"); }

        }
        public DateTime EntradaTarde
        {
            get { return Convert.ToDateTime("11:00"); }

        }
        public DateTime SaidaTarde
        {
            get { return Convert.ToDateTime("20:00"); }

        }
        public DateTime EntradaSabado
        {
            get { return Convert.ToDateTime("08:00"); }

        }
        public DateTime SaidaSabado
        {
            get { return Convert.ToDateTime("18:00"); }

        }
        public enum TurnoFunc 
        {
            Manha,
            Tarde
        }
        public DateTime[] RetornaHorarioDeTrabalho(TurnoFunc turno)
        {
            DateTime[] turnoFunc = new DateTime[2];
            if (turno == TurnoFunc.Manha)
            {
                
                turnoFunc[0] = EntradaManha;
                turnoFunc[1] = SaidaManha;

                
            }
            return turnoFunc;

        }

    }
}
