/*
Nome: Laidone
Laboratório 9
*/

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

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido"; 
            paises[33] = "França";
            paises[55] = "Brasil"; 
            Console.WriteLine("O código 55 é: {0}", paises[55]); 
            foreach (KeyValuePair<int, string> item in paises) 
            { 
            int codigo = item.Key; 
            string pais = item.Value;
            Console.WriteLine("Código {0} = {1}", codigo, pais); 
            //Recuperando o código a partir do valor
            }
           int key;
           foreach (KeyValuePair<int, string> item in paises)
           {
               if(item.Value == "Reino Unido")
               {
                   key = item.Key;
                   System.Console.WriteLine(key);
               }
               else if (item.Value == "França")
               {
                  key = item.Key;
                  System.Console.WriteLine(key);
               }
               else{
                  key = item.Key;
                  System.Console.WriteLine(key);
               }
           }
            /*Dada uma lista de números reais, implemente um método TotalAcimaMedia, para calcular e retornar o 
            número de elementos da lista cujos valores são maiores do que a média de todos os elementos.*/
            List<double> lista = new List<double>();
            lista.Add(1.0);
            lista.Add(6.9);
            lista.Add(20);
            lista.Add(4.1);
            lista.Add(8.8);
            lista.Add(6.0);
            lista.Add(2.2);
            lista.Add(3.4);
            lista.Add(1.6);
            System.Console.WriteLine("O número de elementos da lista cujos valores são maiores do que a média de todos os elementos é " + TotalAcimaMedia(lista));
            System.Console.Write("Lista com valores acima da média: ");
            for (int i = 0; i < ListaAcimaMedia(lista).Count; ++i)
            {
                System.Console.Write(ListaAcimaMedia(lista)[i] + " ");
            }
        }
        public static int TotalAcimaMedia(List<double> lista)
        {
            double soma = 0.0;
            double media = 0.0;
            int total = 0;
            for(int i = 0; i < lista.Count; ++i)
            {
                soma = soma + lista[i];
            }
            media = soma/lista.Count;
            for(int i = 0; i < lista.Count; ++i)
            {
                if(lista[i] > media)
                {
                    ++total;
                }
            }
            return total;
        }
        //Método para lista com valores acima da média
        public static List<double> ListaAcimaMedia(List<double> lista)
        {
            double soma = 0.0;
            double media = 0.0;
            List<double> lista_acima_media = new List<double>();
            for(int i = 0; i < lista.Count; ++i)
            {
                soma = soma + lista[i];
            }
            media = soma/lista.Count;
            for(int i = 0; i < lista.Count; ++i)
            {
                if(lista[i] > media)
                {
                    lista_acima_media.Add(lista[i]);
                }
            }
            return lista_acima_media;
        }
    }
}