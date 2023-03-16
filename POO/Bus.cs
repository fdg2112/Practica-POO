using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace POO
{
    public class Bus : PublicTransport
    {
        static int nextId;
        public Bus(int passengersNumber) : base(passengersNumber)
        {
            this.TransportId = Interlocked.Increment(ref nextId);
            this.Name = "Colectivo";
        }

        public override string Move()
        {
            return ($"El colectivo {TransportId} ha avanzado");
        }

        public override string Stop()
        {
            return ($"El colectivo {TransportId} se ha detenido");
        }
    }
}
