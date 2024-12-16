namespace a_class_object_method;

class Student
{
    public void hello()
    {
        Console.WriteLine("Good morning Students");
    }

    static void Main(string[] args)
    {
        /* creating an object in C#
        class_name object = new class_name(); */
        Student s1 = new Student();
        s1.hello();
    }
}
