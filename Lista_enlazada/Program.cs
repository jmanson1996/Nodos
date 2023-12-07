namespace Lista_enlazada
{
    class Program
    {
        static void Main()
        {
            var list = new ListaNodo(); ;
            list.ListaVacia();
            list.addNodo(3);
            list.addNodo(4);
            list.addNodo(5);
            list.addNodo(1);
            list.addNodo(2);
            list.Listar();
            list.Buscar(3);
            Console.WriteLine();
            list.Listar();
            Console.ReadKey();
        }
    }




}