// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace CPRG211E_Lab_2;

class Program
{
    static void Main()
    {
        //reading and splitting data by new line and adding to list
        string path = "C:\\Users\\Jedi4\\source\\repos\\CPRG211ELab2\\CPRG211E Lab 2\\res\\employees.txt";

        string data = File.ReadAllText(path);

        string[] dataSplit = data.Split("\n");

        List<object> DataList = new List<object>();


        for (int i = 0; i < dataSplit.Length; i++)
        {
            DataList.Add(dataSplit[i]);
        }

        //Take each line of data and turn into array to input into employee objects
        string[] employeeOneDetails = DataList[0].ToString().Split(':');
        string[] employeeTwoDetails = DataList[1].ToString().Split(':');
        string[] employeeThreeDetails = DataList[2].ToString().Split(':');
        string[] employeeFourDetails = DataList[3].ToString().Split(':');
        string[] employeeFiveDetails = DataList[4].ToString().Split(':');
        string[] employeeSixDetails = DataList[5].ToString().Split(':');
        string[] employeeSevenDetails = DataList[6].ToString().Split(':');
        string[] employeeEightDetails = DataList[7].ToString().Split(':');
        string[] employeeNineDetails = DataList[8].ToString().Split(':');

        //create list of arrays for a for loop to input data for employees
        List<string[]> strings = new List<string[]>();

        strings.Add(employeeOneDetails);
        strings.Add(employeeTwoDetails);
        strings.Add(employeeThreeDetails);
        strings.Add(employeeFourDetails);
        strings.Add(employeeFiveDetails);
        strings.Add(employeeSixDetails);
        strings.Add(employeeSevenDetails);
        strings.Add(employeeEightDetails);
        strings.Add(employeeNineDetails);

        //create lisst for employee objects and pay group 
        List<Employee> employeeList = new List<Employee>();
        List<Salaried> salaried = new List<Salaried>();
        List<PartTime> partTime = new List<PartTime>();
        List<Wages> wages = new List<Wages>();

        //for loop to input data, adding employee to total list and pay group list
        for (int i = 0; i < strings.Count; i++)
        {
            string[] employeeDetails = strings[i];

            string check = employeeDetails[0].ToString();


            if (check.StartsWith("09"))
            {
                Employee employeeOne = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Salaried salariedOne = new Salaried(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]));
                employeeList.Add(employeeOne);
                salaried.Add(salariedOne);
            }
            else if (check.StartsWith("1"))
            {
                Employee employeeTwo = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Salaried salariedTwo = new Salaried(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]));
                employeeList.Add(employeeTwo);
                salaried.Add(salariedTwo);
            }
            else if (check.StartsWith("2"))
            {
                Employee employeeThree = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Salaried salariedThree = new Salaried(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]));
                employeeList.Add(employeeThree);
                salaried.Add(salariedThree);
            }
            else if (check.StartsWith("541"))
            {
                Employee employeeFour = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Wages wagesOne = new Wages(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]), double.Parse(employeeDetails[8]));
                employeeList.Add(employeeFour);
                wages.Add(wagesOne);
            }
            else if (check.StartsWith("548"))
            {
                Employee employeeFive = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Wages wagesTwo = new Wages(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]), double.Parse(employeeDetails[8]));
                employeeList.Add(employeeFive);
                wages.Add(wagesTwo);
            }
            else if (check.StartsWith("6"))
            {
                Employee employeeSix = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Wages wagesThree = new Wages(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]), double.Parse(employeeDetails[8]));
                employeeList.Add(employeeSix);
                wages.Add(wagesThree);
            }
            else if (check.StartsWith("7"))
            {
                Employee employeeSeven = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                Wages wagesFour = new Wages(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]), double.Parse(employeeDetails[8]));
                employeeList.Add(employeeSeven);
                wages.Add(wagesFour);
            }
            else if (check.StartsWith("8"))
            {
                Employee employeeEight = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                PartTime partTimeOne = new PartTime(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]), double.Parse(employeeDetails[8]));
                employeeList.Add(employeeEight);
                partTime.Add(partTimeOne);
            }
            else if (check.StartsWith("9"))
            {
                Employee employeeNine = new Employee(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6]);
                PartTime partTimeTwo = new PartTime(employeeDetails[0], employeeDetails[1], employeeDetails[2], employeeDetails[3], long.Parse(employeeDetails[4]), employeeDetails[5], employeeDetails[6], double.Parse(employeeDetails[7]), double.Parse(employeeDetails[8]));
                employeeList.Add(employeeNine);
                partTime.Add(partTimeTwo);
            }   
        }

        //Using list function to find the average page of each pay group
        double salariedAveragePay = salaried.Average(x => x.getPay());
        double wagesAveragepay = wages.Average(x => x.getPay());
        double partTimeAveragePay = partTime.Average(x => x.getPay());

        //Finding the average pay for all employees
        double averagePay = (salariedAveragePay + wagesAveragepay + partTimeAveragePay) / employeeList.Count;

        Console.WriteLine($"The average weekly pay for all employees is ${averagePay.ToString("0.00")}");

        // Using the list functions to find the highest paid wage employee
        Console.WriteLine($"The Employee with the highest weekly pay for wage employees is {wages.Find(x => x.getPay() == wages.Max(x => x.getPay())).getName()} at {wages.Find(x => x.getPay() == wages.Max(x => x.getPay())).getPay().ToString("0.00")}");

        //Using the list funciton to find the lowet paid employee 
        Console.WriteLine($"The Employee with the lowest salary for the salaried employees is {salaried.Find(x => x.getPay() == salaried.Min(x => x.getPay())).getName()} at {salaried.Find(x => x.getPay() == salaried.Min(x => x.getPay())).getPay().ToString("0.00")} ");

        //Obtaining the percentages by dividing the list amounts of the pay groups by total employees
        double percentOfSalaried = (double.Parse(salaried.Count().ToString()) / double.Parse(employeeList.Count().ToString()) * 100 ) ;
        double percentOfWages = (double.Parse(wages.Count().ToString()) / double.Parse(employeeList.Count().ToString()) * 100);
        double percentOfPartTime = (double.Parse(partTime.Count().ToString()) / double.Parse(employeeList.Count().ToString()) * 100);



        Console.WriteLine($"Salaried Employees make up {percentOfSalaried.ToString("0.00")}% of Employees\n" +
                          $"Waged Employees make up {percentOfWages.ToString("0.00")}% of Employees\n" +
                          $"Part Time Employees make up {percentOfPartTime.ToString("0.00")}% of Employees");
    }
}


       

 