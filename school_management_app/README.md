# School Management App

This is a simple school management application designed to manage staff, teachers, subjects, and classes within a school.

## Features

- **Staff Management**: Add, edit, and remove staff members including teachers.
- **Teacher Management**: Assign class teachers, manage subjects taught by teachers.
- **Subject Management**: Add and remove subjects offered by the school.
- **Class Management**: Create and manage classes, assign class teachers, and associate subjects with classes.

## Classes

### Staff

Represents a staff member in the school.

Attributes:
- Name
- ID
- Job Description
- Salary

Methods:
- GetName()
- SetName()
- GetId()
- SetId()
- GetJobDescription()
- SetJobDescription()
- GetSalary()
- SetSalary()

### Teacher : Staff

Represents a teacher in the school, inheriting from the Staff class.

Additional Attributes:
- IsClassTeacher
- Subjects
- ClassName

Additional Methods:
- IsClassTeacher()
- SetClassTeacher()
- GetSubjects()
- AddSubject()
- GetClassName()
- SetClassName()

### Subject

Represents a subject offered by the school.

Attributes:
- Name
- SchoolClass

### SchoolClass

Represents a class in the school.

Attributes:
- Class Name
- Class Teacher

Methods:
- GetClassName()
- GetClassTeacher()
- SetClassTeacher()
