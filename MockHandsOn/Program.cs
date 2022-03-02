using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockHandsOn
{
    internal class Program
    {
        class Employee
        {
            private int EmpID { get; set; }
            private string EmpName { get; set; }
            private string DeptName { get; set; }
            private string Designation { get; set; }
            private int Salary { get; set; }
            public void GetEmpInformation(int EmpID, string EmpName, string DeptName, string Designation, int Salary)
            {
                this.EmpID = EmpID;
                this.EmpName = EmpName;
                this.DeptName = DeptName;
                this.Designation = Designation;
                this.Salary = Salary;

            }
            public void DisplayEmpInformation()
            {
                string result=string.Format("{0,5} {1,5} {2,5} {3,5} {4,5}",this.EmpID,this.EmpName,this.DeptName,this.Designation,this.Salary);
                Console.WriteLine(result);

            }
            static void Main()
            {
                Console.WriteLine("Enter number of Employees");
                int N = int.Parse(Console.ReadLine());
                Employee[] emp = new Employee[10];

                for (int i = 0; i < N; i++)
                {

                    emp[i] = new Employee();
                    Console.WriteLine("Enter your Id:");
                    emp[i].EmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your Name:");
                    emp[i].EmpName = Console.ReadLine();
                    Console.WriteLine("Enter your DepartmentName:");
                    emp[i].DeptName = Console.ReadLine();
                    Console.WriteLine("Enter your Designation:");
                    emp[i].Designation = Console.ReadLine();
                    Console.WriteLine("Enter your BasicPay:");
                    emp[i].Salary = int.Parse(Console.ReadLine());
                    emp[i].GetEmpInformation( emp[i].EmpID, emp[i].EmpName, emp[i].DeptName, emp[i].Designation, emp[i].Salary);
                }
                Console.WriteLine("**********************************************************************************");
                Console.WriteLine("{0,5} {1,5} {2,5} {3,5} {4,5}", "Id", "Name", "Department", "Designation", "Salary");
                Console.WriteLine("**********************************************************************************");
                for (int i = 0; i < N; i++)
                {

                    emp[i].DisplayEmpInformation();
                }
                Console.WriteLine("**********************************************************************************");
                int TotalSalary = 0;
                for (int i = 0; i < N; i++)
                {
                    TotalSalary += emp[i].Salary;
                }
                Console.WriteLine("Total Salary of All Employees                 " + TotalSalary);



                Console.ReadKey();

            }

        }
    }
}
