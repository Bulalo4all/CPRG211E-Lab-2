using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_2
{
    internal class Wages: Employee
    {
        protected double rate;
        protected double hours;

        public Wages() { }

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
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
            double pay;
            if (this.hours > 40)
            {
                pay = rate * 40;
                double overTimeHours = this.hours - 40;
                
                pay = pay +  (overTimeHours * (rate * 1.5));

                return pay;
            }
            else
            {
                pay = this.rate * this.hours;
                return pay;
            }
        }

        public virtual void ToString()
        {
            return;
        }
    }


}

