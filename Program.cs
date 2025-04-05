// Unidad1Ejercicios
// Integrantes del grupo:
// - Charls - 2025 C#
// - Facundo Flores 
// - Nicolas Spadola 
// - Gabriel Zequin  

using System;

namespace FloresSpadolaZequinCharls
{
    class Program
    {
        static void Main()
        {
            // --- Sección de Solicitud de Datos al Usuario ---

            // Solicitar el nombre de usuario
            Console.Write("Ingrese su usuario: ");
            string usuario = Console.ReadLine(); // Leer la entrada del usuario y almacenarla en la variable 'usuario'

            // Solicitar el apellido del usuario
            Console.Write("Ingrese su apellido: ");
            string apellido = Console.ReadLine(); // Leer la entrada del usuario y almacenarla en la variable 'apellido'

            // Solicitar el nombre del usuario
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine(); // Leer la entrada del usuario y almacenarla en la variable 'nombre'

            // Solicitar el número de celular del usuario
            Console.Write("Ingrese su celular: ");
            string celular = Console.ReadLine(); // Leer la entrada del usuario y almacenarla en la variable 'celular'

            // --- Sección de Mensaje con Datos Ingresados ---

            // Mostrar un mensaje con los datos ingresados por el usuario
            Console.WriteLine($"La persona: {apellido}, {nombre} tiene el usuario: {usuario} y el celular: {celular}.");
            // Se utiliza la interpolación de cadenas ($"...") para incluir las variables en el mensaje

            // --- Sección de Definición e Inicialización de Variables ---

            // Definir e inicializar variables de diferentes tipos
            bool miBool = true; // Variable booleana (true o false)
            byte miByte = 255; // Variable de tipo byte (0 a 255)
            char miChar = 'A'; // Variable de tipo carácter (un solo carácter)
            decimal miDecimal = 12.34m; // Variable de tipo decimal (para precisión financiera, el sufijo 'm' indica que es decimal)
            double miDouble = 45.6789; // Variable de tipo double (número de punto flotante de doble precisión)
            float miFloat = 9.81f; // Variable de tipo float (número de punto flotante, el sufijo 'f' indica que es float)
            int miInt = 100; // Variable de tipo entero (número entero)
            long miLong = 1234567890L; // Variable de tipo long (entero largo, el sufijo 'L' indica que es long)
            short miShort = 32000; // Variable de tipo short (entero corto)
            string miString = "Hola, profesor Germán Balbastro"; // Variable de tipo cadena de texto (conjunto de caracteres)

            // --- Sección de Mostrar Valores de Variables ---

            // Mostrar valores de las variables
            Console.WriteLine($"bool: {miBool}"); // Mostrar el valor de la variable 'miBool'
            Console.WriteLine($"byte: {miByte}"); // Mostrar el valor de la variable 'miByte'
            Console.WriteLine($"char: {miChar}"); // Mostrar el valor de la variable 'miChar'
            Console.WriteLine($"decimal: {miDecimal}"); // Mostrar el valor de la variable 'miDecimal'
            Console.WriteLine($"double: {miDouble}"); // Mostrar el valor de la variable 'miDouble'
            Console.WriteLine($"float: {miFloat}"); // Mostrar el valor de la variable 'miFloat'
            Console.WriteLine($"int: {miInt}"); // Mostrar el valor de la variable 'miInt'
            Console.WriteLine($"long: {miLong}"); // Mostrar el valor de la variable 'miLong'
            Console.WriteLine($"short: {miShort}"); // Mostrar el valor de la variable 'miShort'
            Console.WriteLine($"string: {miString}"); // Mostrar el valor de la variable 'miString'

            // --- Sección de Mostrar Valores Mínimo y Máximo de Tipos Numéricos ---

            // Mostrar valores mínimo y máximo de cada tipo numérico
            Console.WriteLine($"int: Min {int.MinValue} - Max {int.MaxValue}"); // Mostrar los valores mínimo y máximo de 'int'
            Console.WriteLine($"byte: Min {byte.MinValue} - Max {byte.MaxValue}"); // Mostrar los valores mínimo y máximo de 'byte'
            Console.WriteLine($"decimal: Min {decimal.MinValue} - Max {decimal.MaxValue}"); // Mostrar los valores mínimo y máximo de 'decimal'
            Console.WriteLine($"double: Min {double.MinValue} - Max {double.MaxValue}"); // Mostrar los valores mínimo y máximo de 'double'
            Console.WriteLine($"float: Min {float.MinValue} - Max {float.MaxValue}"); // Mostrar los valores mínimo y máximo de 'float'
            Console.WriteLine($"long: Min {long.MinValue} - Max {long.MaxValue}"); // Mostrar los valores mínimo y máximo de 'long'
            Console.WriteLine($"short: Min {short.MinValue} - Max {short.MaxValue}"); // Mostrar los valores mínimo y máximo de 'short'

            // --- Sección de Errores de Inicialización (Comentados) ---

            // Errores de inicialización de variables:
            // int numero = "string"; // ERROR: No se puede asignar una cadena a un int
            // string cadena = 2; // ERROR: No se puede asignar un número a un string directamente
            // bool booleano = "true"; // ERROR: "true" es una cadena, no un valor booleano

            // --- Sección de Pausa al Final ---

            // Evitar que la pantalla se cierre inmediatamente (solo se necesita una vez)
            Console.WriteLine("Presione cualquier tecla para salir..."); // Mostrar mensaje al usuario
                                                                         //Console.WriteLine("Presione cualquier tecla para salir...");  Esta linea es redundante
            Console.ReadKey(); // Esperar a que el usuario presione una tecla
        }
    }

}
