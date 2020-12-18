using System;

namespace Single_Responsibility_Principle
{
    // S : Single Responsibility Principle (SRP)
    // Each Class/Module should have single task.

    interface IEmployee // Employee Login Task
    {
        void EmpLogin(string Id, string password);
        void RegisterEmp(string EmpName);
    }

    interface ILogError // Error Log Task
    {
        void ErrorLog(string error);
    }

    interface ISendMail // Email Sent Task
    {
        void MailSend(string message);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
