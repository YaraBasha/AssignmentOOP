using System;

namespace EmployeeApp
{

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secertary,
        DBA
    }

    Public Class Employee
{
        public int ID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }
    private char _gender;
    public SecurityLevel Security { get; set; }

    /*public char Gender
    {
        get { return _gender; }
        set
        {
            if (value == 'M' || value == 'F')
            {
                _gender = value;
            }
            else
            {
                throw new ArgumentException("Gender must be Male or Female");
            }
        }
    }*/

    public Employee(int id, string name, decimal salary, DateTime hireDate, char gender, SecurityLevel security)
    {
        ID = id;
        Name = name;
        Salary = salary;
        HireDate = hireDate;
        Gender = gender;
        Security = security;
    }

    public override string ToString()
    {
        return String.Format(
            "ID: {0}, Name: {1}, Salary: {2:C}, Hire Date: {3:d}, Gender: {4}, Security Level: {5}",
            ID, Name, Salary, HireDate, Gender, SecurityPrivilege);
    }

}
}