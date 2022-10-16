//Criando a Fila
Queue<int> fila = new Queue<int>();

//Atribuindo valores a fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
//Removendo o primeira da fila usando Dequeue
Console.WriteLine($" Removendo o elemento: { fila.Dequeue()}");

// atribuindo um valor ele irá para o final da fila
fila.Enqueue(10);

foreach (int item in fila)
{
    Console.WriteLine(item);
}
