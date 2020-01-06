using System;
using System.Collections.Generic;
using System.Globalization;
using PoliformismoFuncionarios.Entities;

/*
 *  SOFTWARE DESENVOLVIDO POR ALESSANDRO M FUKUTA
 *  ATRAVES DO CURSO C-SHARP DA UDEMY
 *  DATA: 05/01/2020 - AULA EXERCICIOS N. 130
 *  
 * */

namespace PoliformismoFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lst = new List<Employee>();

            Console.Write("Enter the number of employees....: ");
            int ne = int.Parse(Console.ReadLine());
            
            for (int i=0; i < ne; i++)
            {
                Console.WriteLine("Employee #{0} Data" , i+1);
                Console.Write("Outsourced Y/N...........: ");
                string outs = Console.ReadLine();

                Console.Write("Name.................: ");
                string wname = Console.ReadLine();

                Console.Write("Hours................: ");
                int whours = int.Parse(Console.ReadLine());

                Console.Write("Value per Hour.......: ");
                double wvalueperhour = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                double wadditional = 0;

                if (outs=="Y" || outs=="y")
                {
                    Console.Write("Additional Charge....: ");
                    wadditional = double.Parse(Console.ReadLine(), CultureInfo.CurrentCulture);
                    OutsourcedEmployee outsourced = new OutsourcedEmployee(wname, whours, wvalueperhour,wadditional);
                    lst.Add(outsourced);
                } else
                {
                    Employee employee = new Employee(wname, whours, wvalueperhour);
                    lst.Add(employee);
                }

            }

            foreach(Employee obj in lst)
            {
                Console.WriteLine(obj.Name + " - $ " + obj.Payment().ToString("C", CultureInfo.CurrentCulture));
            }


        }
    }
}
