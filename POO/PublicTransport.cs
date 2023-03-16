using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class PublicTransport
    {
        public PublicTransport(int passengersNumber)
        {
            this.PassengersNumber = passengersNumber;
        }
        public int TransportId { get; set; }
        public string Name { get; set; }
        public int PassengersNumber { get; set; }
        public abstract string Move();
        public abstract string Stop();
    }
}
