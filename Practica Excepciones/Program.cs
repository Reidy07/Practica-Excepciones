using System;
using System.Threading.Channels;

namespace PracticaExcepciones
{
    public class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Console.WriteLine("Ingrese su nombre");
                string nombre = Console.ReadLine();


                Console.WriteLine("Ahora ingrse la contraseña");
                string contraseña = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no debe de estar vacio");
                }
                if (contraseña.Length < 8)
                {
                    throw new ArgumentException("La contraseña debe de tener mas de 8 digitos");
                }
                Console.WriteLine("LA validacion se hizo exitosamente");
            }
            catch (ArgumentException ex)
			{
                Console.WriteLine($"Error: {ex.Message}");
			}
            finally
            {
                Console.WriteLine("El proceso ya a finalizado");
            }

        }   

    }
}
