public static class StudentExtensions
{
    // extension method static class ichida
    // static qilib elon qilinadi
    public static void Print(this Student student)
    {
        Console.WriteLine($"{student.Id}. {student.Name} -- {student.Grade}");
    }

    public static int ToInt(this string str)
    {
        return int.Parse(str);
    }
}