class Boxeador
{
    public string nombre{get;set;}

    public string pais{get;set;}

    public double peso{get;set;}

    public int potenciaGolpes{get;set;}

    public int velocidadPatadas{get;set;}

    public Boxeador()
    {

    }
    public Boxeador(string nom,string paiss, double pesos, int pg, int vp)
    {
    nombre = nom;
    pais = paiss;
    peso = pesos;
    potenciaGolpes = pg;
    velocidadPatadas = vp;
    }

    public double obtenerSkill()
    {
        int numAzar = new Random().Next(0, 101); 
        double skills = velocidadPatadas * 0.6 + potenciaGolpes * 0.8 + numAzar; 
        return skills;
    }

}