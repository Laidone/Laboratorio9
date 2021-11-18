

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Código para criar filas de objetos
            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework / Core"); 
            q.Enqueue(new Decimal(123.456)); 
            q.Enqueue(654.321); 
            Console.WriteLine(q.Dequeue()); 
            Console.WriteLine(q.Dequeue()); 
            Console.WriteLine(q.Dequeue());

            //Código para criar filas de inteiros
            Queue<int> minhaFila = new Queue<int>(); 
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200); 
            minhaFila.Enqueue(1000); 
            Console.WriteLine(minhaFila.Dequeue()); 
            Console.WriteLine(minhaFila.Dequeue()); 
            Console.WriteLine(minhaFila.Dequeue());
        }

    }
}