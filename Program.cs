
        Boxeador boxeador1 = new Boxeador();
        Boxeador boxeador2 = new Boxeador();
        int PotenciaGolpes = 0;
        int VelocidadPatada = 0;
        int opcion = 0;
        double skillBox2 = 0;
        double skillBox1 = 0;
do
{
    Console.WriteLine("1. Cargar Datos Boxeador 1");
    Console.WriteLine("2. Cargar Datos Boxeador 2");
    Console.WriteLine("3. Pelear!");
    Console.WriteLine("4. salir");
    
    opcion = Funciones.IngresarEntero("Ingrese un numero");
    switch(opcion)
    {   
        case 1:
        boxeador1 = CargarDatosBoxeador();
        skillBox1 = boxeador1.obtenerSkill();       
        break;
        case 2:
        boxeador2 = CargarDatosBoxeador();
        skillBox2 = boxeador2.obtenerSkill();    
        break;
        case 3:
        pelear(skillBox1,skillBox2,boxeador1,boxeador2);
        break;
    }
}while(opcion < 4);

Boxeador CargarDatosBoxeador()
{
    string nombre = Funciones.IngresarTexto("Ingrese el nombre del boxeador: ");
    string pais = Funciones.IngresarTexto("Ingrese el pais del boxeador: ");
    double peso = Funciones.IngresarEntero("Ingrese el peso del boxeador: ");
    PotenciaGolpes = 
    VelocidadPatada = new Random().Next(1,100);
    Boxeador box = new Boxeador(nombre,pais,peso,PotenciaGolpes,VelocidadPatada ); 

    return box;
}
static void pelear(double skillBox1, double skillBox2, Boxeador boxeador1, Boxeador boxeador2)
{
    if(skillBox1 - skillBox2 >= 30) Console.WriteLine("Ha ganado el boxeador" + boxeador1.nombre);
    else if(skillBox2 - skillBox1 >= 30) Console.WriteLine("Ha ganado el boxeador" + boxeador2.nombre);
    else if(skillBox1 - skillBox2 >= 10 && skillBox1 - skillBox2 < 30) Console.WriteLine("Ha ganado el boxeador " + boxeador1.nombre + " por puntos en fallo unanime");
    else if(skillBox2 - skillBox1 >= 10 && skillBox2 - skillBox1 < 30) Console.WriteLine("Ha ganado el boxeador " + boxeador2.nombre + " por puntos en fallo unanime");
    else if(skillBox1 - skillBox2 < 10) Console.WriteLine("Ha ganado el boxeador" + boxeador1.nombre + " por puntos en fallo dividido");
    else if(skillBox2 - skillBox1 < 10) Console.WriteLine("Ha ganado el boxeador" + boxeador2.nombre + " por puntos en fallo dividido");
}