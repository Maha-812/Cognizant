using System;

class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Grade { get; set; }

    public Student(string name, int id, string grade)
    {
        Name = name;
        Id = id;
        Grade = grade;
    }
}

class StudentView
{
    public void DisplayStudentDetails(string name, int id, string grade)
    {
        Console.WriteLine("Student Details:");
        Console.WriteLine("Name  : " + name);
        Console.WriteLine("ID    : " + id);
        Console.WriteLine("Grade : " + grade);
    }
}

class StudentController
{
    private Student model;
    private StudentView view;

    public StudentController(Student model, StudentView view)
    {
        this.model = model;
        this.view = view;
    }

    public void SetStudentName(string name)
    {
        model.Name = name;
    }

    public string GetStudentName()
    {
        return model.Name;
    }

    public void UpdateView()
    {
        view.DisplayStudentDetails(
            model.Name,
            model.Id,
            model.Grade
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student model = new Student(
            "Mahalakshmi",
            101,
            "A"
        );

        StudentView view = new StudentView();

        StudentController controller =
            new StudentController(model, view);

        controller.UpdateView();

        Console.WriteLine("\nAfter Updating Name:\n");

        controller.SetStudentName("Sri Mahalakshmi");

        controller.UpdateView();
    }
}