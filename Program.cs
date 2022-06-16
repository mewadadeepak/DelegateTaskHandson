using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTaskHandsonToday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            List<Employee> emp = new List<Employee>
           {
                 new Employee{ Id = 1111, Name = "Manish", Salary = 10000, Experiance = 4 },
                 new Employee{ Id = 1112, Name = "Swati", Salary = 20000, Experiance = 5 },
                 new Employee{ Id = 1113, Name = "Ankit", Salary = 35000, Experiance = 7 },
                 new Employee{ Id = 1114, Name = "Mikle", Salary = 44000, Experiance = 8 },
           };

            //1: Delegate object
            Employee.isPromote isPromoted = new Employee.isPromote(Employee.promote);//passing method reference of promote method

            isPromoted += new Employee.isPromote(Employee.promoteBySal);//passing method reference of promoteBySal method

            // Employee.PromoteEmp(emp, isPromoted);






            //2 : creating myDelegate class object
            SampleDeleg sampleDeleg = new SampleDeleg();
            // Creates one delegate for each method. For the instance method, an
            // instance (mySC) must be supplied. For the static method, use the
            // class name.
            SampleDeleg.myMethodDelegate myD1 = new SampleDeleg.myMethodDelegate(SampleDeleg.mySignMethod);
            SampleDeleg.myMethodDelegate myD2 = new SampleDeleg.myMethodDelegate(sampleDeleg.myStringMethod);

            // Invokes the delegates.
            //Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 5, myD1(5), myD2(5));
            //Console.WriteLine("{0} is {1}; use the sign \"{2}\".", -3, myD1(-3), myD2(-3));
            //Console.WriteLine("{0} is {1}; use the sign \"{2}\".", 0, myD1(0), myD2(0));


            //3: Build-in delegate func.
            PreBuildDelegateFunction.Add = PreBuildDelegateFunction.SumOfWeight;
            PreBuildDelegateFunction.AtheletePerformance("Deepak Mewada", PreBuildDelegateFunction.Add);


        }
    }
}