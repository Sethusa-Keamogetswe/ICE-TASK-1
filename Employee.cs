using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name;
    private string surname;
    private string departmentName;
    private double sales;

    public Employee()
    {
        name = "";
        surname = "";
        departmentName = "";
        sales = 0.0;

    }

    public void setName(string n)
    {
        if (!string.IsNullOrEmpty(n))
        {
            name = char.ToUpper(n[0]) + n.Substring(1).ToLower();
        }
    }

    public void setSurname(string s)
    {
        surname = s.ToUpper();

    }

    public void setDepartmentName(char d)
    {
        d = Char.ToUpper(d);

        if (d == 'E')
            departmentName = "Electronics";
        else if (d == 'H')
            departmentName = "Hardware";
        else if (d == 'S')
            departmentName = "Sportswear";
        else
            departmentName = "Unknown";

    }

    public void setSales(double s)
    {
        if (s < 2000)
            sales = 2000;
        else 
            sales = s;
        
    }

    public double calcSalary()
    {
        double basicSalary = 3000;
        double commission = 0;

        if (departmentName == "Hardware")
            commission = sales * 0.02;
        else if (departmentName == "Electronics")
            commission = sales * 0.035;
        else if (departmentName == "Sportswear")
            commission = sales * 0.045;
        return basicSalary + commission;
    }

    public String getName()
    {
        return name;
    }
    public string getSurname()
    {
        return surname;
    }
    public string getDepartmentName()
    {
        return departmentName;
    }
}


