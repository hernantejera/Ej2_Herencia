namespace Ej2_Herencia
{
    //Crea una clase base llamada "Bebida" con propiedades como "Nombre" y "Precio".
    //Luego, crear clases derivadas como "Refresco" y "Cerveza" que hereden de "Bebida"
    //y agreguen propiedades y métodos específicos para cada tipo de bebida.
    //Cerveza tiene grado de alcohol y amargor
    //Refresco tiene sabor y marca

    internal class Program
    {
        static void Main(string[] args)
        {
            Refresco refresco = new Refresco()
            {
            Nombre = "Gaseosa",
            Precio = 300,
            Sabor = "Naranja",
            Marca = "Fanta",
            };

            Cerveza cerveza = new Cerveza() 
            {
            Nombre = "Birra",
            Precio = 500,
            Amargor = 28.5,
            GradoAlcohol = 8,
            };
            Console.WriteLine($"El refresco {refresco.Nombre} tiene un precio de" +
                $" $ {refresco.Precio} , su sabor es {refresco.Sabor} y su marca es {refresco.Marca}.");
            Console.WriteLine($"La cerveza {cerveza.Nombre} tiene un precio de" +
                $" $ {cerveza.Precio}, tiene un amargor de {cerveza.Amargor}" +
                $" ibu y tiene {cerveza.GradoAlcohol} % de alcohol.");
        }
    }
}