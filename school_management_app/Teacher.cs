using System;

class Teacher : Staff
{
	private bool _isClassTeacher;
	private List<Subject> _subjects;
	private SchoolClass _className;

	public Teacher(string name, int id, string jobDescription, double salary) : base(name, id, jobDescription, salary)
	{
		_isClassTeacher = false;
		_subjects = new List<Subject>();
		_className = null;
	}

	public bool IsClassTeacher()
	{
		return _isClassTeacher;
	}

	public void SetClassTeacher(bool isClassTeacher)
	{
		_isClassTeacher = isClassTeacher;
	}

	public List<Subject> GetSubjects()
	{
		return _subjects;
	}

	public void AddSubject(Subject subject)
	{
		_subjects.Add(subject);
	}

	public SchoolClass GetClassName()
	{
		return _className;
	}

	public void SetClassName(SchoolClass className)
	{
		_className = className;
	}
}
