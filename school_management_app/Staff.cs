using System;

public class Staff
{
    private string _name;
    private int _id;
    private string _jobDescription;
    private double _salary;

    public Staff(string name, int id, string jobDescription, double salary)
    {
        _name = name;
        _id = id;
        _jobDescription = jobDescription;
        _salary = salary;
    }

    public string GetName() { return _name; }
    public void SetName(string name) { _name = name; }

    public int GetId() { return _id; }
    public void SetId(int id) { _id = id; }

    public string GetJobDescription() { return _jobDescription; }
    public void SetJobDescription(string jobDescription) { _jobDescription = jobDescription; }

    public double GetSalary() { return _salary; }
    public void SetSalary(double salary) { _salary = salary; }
}

