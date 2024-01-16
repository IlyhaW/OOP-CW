using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
  public  class WorkerOfSalon
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Experience { get; set; }
        public string WorkBegin { get; set; }
        public string WorkEnd { get; set; }

        public static bool operator !=(WorkerOfSalon left, WorkerOfSalon right)
        {
            if ( (left.PhoneNumber != right.PhoneNumber) ||
                (left.Lastname != right.Lastname) ||
                (left.Firstname != right.Firstname))
                return true;
            else return false;
        }
        public static bool operator ==(WorkerOfSalon left, WorkerOfSalon right)
        {
            if ((left.PhoneNumber == right.PhoneNumber) &&
                            (left.Lastname == right.Lastname) &&
                            (left.Firstname == right.Firstname)) return true;
            else return false;
        }
    }
}
