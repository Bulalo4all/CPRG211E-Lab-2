using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CPRG211E_Lab_2
{
    internal class Employee
    {
        protected string Id { get; set; }
        protected string Name { get; set; }
        protected string Address { get; set; }
        
        protected string Phone { get; set; }

        protected long Sin { get; set; }

        protected string Dob { get; set; }

        protected string Dept { get; set; }

        public Employee() { }

        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            this.Sin = sin;
            this.Dob = dob;
            this.Dept = dept;
        }

        public string getId()
        { return this.Id; }

        public string getName() 
        { return this.Name; }

        public string getAddresss()
        { return this.Address; }

        public string getPhone()
        { return this.Phone; }

        public long getSin()
        { return this.Sin; }
        
        public string getDob()
        { return this.Dob; }

        public string getDept()
        { return this.Dept; }

        public override string ToString()
        {
            return $"ID: {this.Id} Name: {this.Name} Address: {this.Address} Phone #: {this.Phone} SIN #: {this.Sin} DOB: {this.Dob} DEPT: {this.Dept}";
        }


    }
}
