using System;
using System.Data;

class Program
{
    public static DataSet GeneraDatos()
    {
        DataTable tbl = new DataTable("Persona");

        // Definir columnas
        tbl.Columns.Add("id", typeof(int));
        tbl.Columns.Add("nombre", typeof(string));
        tbl.Columns.Add("edad", typeof(int));
        tbl.Columns.Add("telefono", typeof(string));

        // Agregar fila
        DataRow row1 = tbl.NewRow();
        row1["id"] = 1;
        row1["nombre"] = "fulano";
        row1["edad"] = 48;
        row1["telefono"] = "5541885810";

        tbl.Rows.Add(row1);

        // Crear y retornar el DataSet
        DataSet dst = new DataSet("Base");
        dst.Tables.Add(tbl);
        return dst;
    }

    public static void Main(string[] args)
    {
        DataSet datos = GeneraDatos();

        // Corregir el bucle
        for (int i = 0; i < datos.Tables[0].Rows.Count; i++)
        {
            Console.Write(datos.Tables[0].Rows[i]["id"] + "-");
            Console.Write(datos.Tables[0].Rows[i]["nombre"] + "-");
            Console.Write(datos.Tables[0].Rows[i]["edad"] + "-");
            Console.WriteLine(datos.Tables[0].Rows[i]["telefono"]);
        }
    }
}