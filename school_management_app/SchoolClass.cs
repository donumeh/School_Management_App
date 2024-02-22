using System;

public class SchoolClass
{
    private string _className;
    private Teacher _classTeacher;

    public SchoolClass(string className)
    {
        _className = className;
        _classTeacher = null;
    }

    public string GetClassName() { return _className; }
    public Teacher GetClassTeacher() { return _classTeacher; }
    public void SetClassTeacher(Teacher teacher) { _classTeacher = teacher; }
}

