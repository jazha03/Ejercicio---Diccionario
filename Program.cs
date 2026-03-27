namespace ejercicio-Diccionarios
{
    public class program
    {
        static void main{}
        {
            Dictionary<string, int> inventario = new Dictionary<string, int>()
            { "Madera", 10 }
            { "Hierro", 8 }
            { "Soga", 6 }
    
            int opcion;
            do
            {
                Console.WriteLine(" MENÚ ");
                Console.WriteLine("1. Ver inventario");
                Console.WriteLine("2. Actualizar stock");
                Console.WriteLine("3. Consumir recurso");
                Console.WriteLine("4. Consultar recurso");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        mostrarInventario(inventario);
                        break;

                    case 2:
                        actualizarStock(inventario);
                        break;

                    case 3:
                        consumirRecurso(inventario);
                        break;

                    case 4:
                        consultarRecurso(inventario);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo");
                        break;
                } 

            }while(opcion != 5);
            
        }
    }
}
            

        
    static void mostrarInventario(Dictionary<string, int> inventario)
    {
        Console.WriteLine("INVENTARIO");

        foreach (var item in inventario)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

    static void actualizarStock(Dictionary<string, int> inventario)
    {
        Console.Write("Ingresá el recurso: ");
        string recurso = Console.ReadLine();

        Console.Write("Cantidad que querés agregar: ");
        int cantidad = int.Parse(Console.ReadLine());

        if (inventario.ContainsKey(recurso))
        {
            inventario[recurso] += cantidad;
            Console.WriteLine("Stock actualizado correctamente.");
        }
        else
        {
            inventario.Add(recurso, cantidad);
            Console.WriteLine("Recurso agregado al inventario.");
        }
    }

    static void consumirRecurso(Dictionary<string, int> inventario)
    {
        Console.Write("Ingresá el recurso a consumir: ");
        string recurso = Console.ReadLine();

        if (inventario.ContainsKey(recurso))
        {
            Console.Write("Cantidad a consumir: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (inventario[recurso] >= cantidad)
            {
                inventario[recurso] -= cantidad;
                Console.WriteLine("Recurso consumido.");

                if (inventario[recurso] < 5)
                {
                    Console.WriteLine("ALERTA: REABASTECER " + recurso.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("No hay suficiente stock");
            }
        }
        else
        {
            Console.WriteLine("El recurso no existe");
        }
    }

    static void consultarRecurso(Dictionary<string, int> inventario)
    {
        Console.Write("Ingresá el recurso a consultar: ");
        string recurso = Console.ReadLine();

        if (inventario.ContainsKey(recurso))
        {
            Console.WriteLine("Stock de " + recurso + ": " + inventario[recurso]);
        }
        else
        {
            Console.WriteLine("Recurso no encontrado.");
        }
    }

