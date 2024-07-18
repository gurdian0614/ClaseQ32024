using ClaseQ32024;

//Instanciar la clase o declarar un nuevo objeto
Ave ave = new Ave();
ave.Nombre = "Pájaro";
ave.Color = "Varios";
ave.Tamano = "Pequeño";
ave.FamiliaAve.Nombre = "Familia de pájaros";
ave.FamiliaAve.Grupo = "Voladores";
ave.SexoBiologico = "Macho";
ave.Imprimir();

Ave ave2 = new Ave();
ave2.Nombre = "Pájaro carpintero";
ave2.Color = "Rojo";
ave2.Tamano = "Mediano";
ave2.FamiliaAve.Nombre = "Familia de pájaros carpinteros";
ave2.FamiliaAve.Grupo = "Carpinteros";
ave2.SexoBiologico = "Hembra";
ave2.EsVoladora = false;
ave2.Imprimir();
