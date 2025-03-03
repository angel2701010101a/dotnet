using System;
public class Program
{

    public static void Main(string[] args)
    {
        Persona p = new Alumno();
        p.Nombre = "yo";
        p.Edad = 200;
        Console.WriteLine(p);

        Persona q = new Alumno("megano", 99, "123456789");
        Console.WriteLine(q);
        Persona r = new Profesor("fulano", 30, "123456788");
        Console.WriteLine(r);
        Persona r = new Profesor("Arturo", 30, "123456789");
        Console.WriteLine(r);
    }
}

abstract class Persona
{
    private string nombre;
    private int edad;

    public Persona() { } //constructor

    public Persona(string nombre, int edad) //
    {

        this.Nombre = nombre;
        this.Edad = edad;
    }
    public string Nombre
    {
        set { nombre = value; }
        get { return nombre; }
    }
    public int Edad
    {
        set { edad = (value >= 0 && value <= 150) ? value : 0; }
        get { return edad; }
    }
    public override string ToString()
    {
        return string.Format("Persona {{Nombre: {0}, Edad: {1}}}", nombre, edad);
    }
}
class Alumno : Persona
{

    public string Boleta { set; get; }
    public Alumno() { }
    public Alumno(string nombre, int edad, string boleta) : base(nombre, edad)
    {
        this.Boleta = boleta;
    }
    public override string ToString()
    {
        return base.ToString() + " " + string.Format("Alumno {{Boleta: {0}}}", Boleta);
    }
}
class Profesor : Persona
{
    public string CveEmpleado { set; get; }
    public Profesor() { }
    public Profesor(string nombre, int edad, string cvempleado) : base(nombre, edad)
    {
        this.CveEmpleado = cvempleado;
    }
    public override string ToString()
    {
        return base.ToString() + " " + string.Format("Profesor {{CveEmpleado: {0}}}", CveEmpleado);
    }
}