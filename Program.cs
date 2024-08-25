using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

int opcion, clases, colegiatura, opcion2;
double num1, num2, suma, resta, Multiplicacion, Division;
double a, b, c, d, e, f;
double g;
double capitalsocial, inversion1, inversion2, inversion3, porcentaje;
String nombre;
int respuesta;


do
{
    Console.WriteLine("Eliga una opcion");
    Console.WriteLine("1. Sacar promedio");
    Console.WriteLine("2. Colegiatura");
    Console.WriteLine("3. Inversiones");
    Console.WriteLine("4. Calculadora");
    Console.WriteLine("5. salir");

    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese nombre del estudiante");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese las notas correspondientes (7)");
            Console.WriteLine("Nota #1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota #2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota #3");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota #4");
            d = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota #5");
            e = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota #6");
            f = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota #7");
            g = double.Parse(Console.ReadLine());
            porcentaje = (a + b + c + d + e + f + g) / 7;
            Console.WriteLine("El estudiante " + nombre + " tiene un promedio de: " + porcentaje + "%");

            break;

        case 2:
            Console.WriteLine("Calcular Colegiatura");
            Console.WriteLine("Ingrese el numero de clases a inscribir");
            clases = int.Parse(Console.ReadLine());
            if (clases >= 1 && clases <= 15)
            {
                colegiatura = clases * 50;
                Console.WriteLine("El monto total por pagar es: " + colegiatura + "C$");
                Console.WriteLine("El precio de cada asignatura es: " + colegiatura / clases);
            }
            else
            {
                Console.WriteLine("Error en el numero de clases");
            }

            break;

        case 3:
            Console.WriteLine("Ingrese el monto del primer inversionista");
            inversion1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto del segundo inversionista");
            inversion2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto del tercer inversionista");
            inversion3 = double.Parse(Console.ReadLine());
            capitalsocial = inversion1 + inversion2 + inversion3;
            Console.WriteLine("La capital social de la empresa es: " + capitalsocial);
            break;

        case 4:
            do
            {
                Console.WriteLine("Bienvenido a la Calculadora");
                Console.WriteLine("Eliga la operacion que desee hacer");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                opcion2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite los 2 numeros para hacer la operacion elegida");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                switch (opcion2)
                {
                    case 1:
                        suma = num1 + num2;
                        Console.WriteLine("La suma de: " + num1 + " + " + num2 + " = " + suma);
                        break;
                    case 2:
                        resta = num1 - num2;
                        Console.WriteLine("La resta de: " + num1 + " - " + num2 + " = " + resta);
                        break;
                    case 3:
                        Multiplicacion = num1 * num2;
                        Console.WriteLine("La multiplicacion de: " + num1 + " * " + num2 + " = " + Multiplicacion);
                        break;
                    case 4:
                        if (num2 < num1 || num2 == 0)
                        {
                            Console.WriteLine("El segundo numero debe de ser mayor al primero");
                        }
                        else
                        {
                            Division = num1 / num2;
                            Console.WriteLine("La division de: " + num1 + " / " + num2 + " = " + Division);
                        }
                        break;
                    default:
                        Console.WriteLine("===OPCIÓN NO VALIDA===");
                        break;
                }
                Console.WriteLine("¿Desea realizar otra operación en la calculadora?");
                Console.WriteLine("1. Sí");
                Console.WriteLine("2. No");
                respuesta = int.Parse(Console.ReadLine());

            } while (respuesta == 1);

            break;

        default:
            Console.WriteLine("===OPCIÓN NO VALIDA===");

            break;
    }

} while (opcion == 5);
