namespace ParoImpar
{

    using ParoImpar.Servicios;
    using System.ComponentModel.Design;

    class Program
    {
        static void Main(string[] args)
        {

            MenuIntefaz num = new MenuImplementacion();

            int numero = num.numero();

            if ((numero % 2) == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es Impar");
            }
        }


    }
}