
namespace ClaseQ32024
{
    public class Ave
    {
        public string Nombre { get; set; }

        public String Color { get; set; }

        public String Tamano { get; set; }

        public FamiliaAve FamiliaAve { get; set; }

        public string SexoBiologico { get; set; }

        public bool EsVoladora { get; set; }

        // Constructor
        public Ave()
        {
            EsVoladora = true;
            FamiliaAve = new FamiliaAve();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Tamaño: {Tamano}");
            Console.WriteLine($"Familia: {FamiliaAve.Nombre}");
            Console.WriteLine($"Grupo Familia: {FamiliaAve.Grupo}");
            Console.WriteLine($"Sexo Biológico: {SexoBiologico}");
            Console.WriteLine($"Es Voladora: {(EsVoladora ? "Sí" : "No")}");
            Console.WriteLine();
        }
    }
}
