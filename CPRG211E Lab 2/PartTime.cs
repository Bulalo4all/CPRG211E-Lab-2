using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_2
{
    internal class PartTime: Employee
    {
        protected double rate;
        protected double hours;

        public PartTime() { }

        public PartTime(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
            this.rate = rate;
            this.hours = hours; 
        }

        public double getPay()
        {
            return rate * hours;
        }

        public virtual void ToString()
        {
            return;
        }




    }
}
