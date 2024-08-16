namespace RiosYang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList listanueva = new LinkedList();

            // Agregamos los datos a la lista
            listanueva.insertarFinal(20);
            listanueva.insertarFinal(30);
            listanueva.insertarFinal(40);
            listanueva.insertarFinal(150);

            listanueva.mostrarLista();

            listanueva.InsertarPosicion(23, 2);

            listanueva.mostrarLista();

            Console.ReadKey();
        }
    }
}