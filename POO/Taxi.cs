using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace POO
{
    public class Taxi : PublicTransport
    {
        static int nextId;
        public Taxi(int passengersNumber) : base(passengersNumber)
        {
            this.TransportId = Interlocked.Increment(ref nextId);
            this.Name = "Taxi";
        }

        public override string Move()
        {
            return ($"El taxi {TransportId} ha avanzado");
        }

        public override string Stop()
        {
            return ($"El taxi {TransportId} se ha detenido");
        }
    }
}
