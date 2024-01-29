using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_2
{
    internal class Salaried: Employee
    {
        protected double salary { get; set; }
        
        public Salaried() { }

        public Salaried(string id, string name, string address, string phone, long sin, string dob, string dept, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
            this.salary = salary;
        }

        public double getPay()
        {
            return this.salary;
        }

        public virtual void ToString()
        {
            return;
        }
    }

    }

