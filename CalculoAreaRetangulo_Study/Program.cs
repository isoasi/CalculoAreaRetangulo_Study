using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        double baseRetangulo, altura, areaRetangulo, perimetro, diagonal;

        baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        areaRetangulo = baseRetangulo * altura;
        perimetro = 2 * baseRetangulo + 2 * altura; 
        //or 2*(baseRetangulo + altura);

        diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2.0) + Math.Pow(altura, 2.0)); 
        //or (baseRetangulo * baseRetangulo) + (altura * altura)

        Console.WriteLine("Area = " + areaRetangulo.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Perimetro = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));
    
        Console.ReadLine();
    }

}

