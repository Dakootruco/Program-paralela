internal class Program
{
    static async Task Main()
    {
        Task task = Task.Factory.StartNew(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tarea ejecutándose: {i}");
            }
            /*
             Usar TaskCreationOptions.LongRunning le dice al ThreadPool de .NET que esta tarea debería 
            ejecutarse en un hilo separado, en lugar de en un hilo del grupo de hilos 
            del sistema, para evitar que se agoten los hilos de ese grupo.
            Cuando usarlo: Si una tarea implica cálculos complejos, acceso a recursos 
            externos (como bases de datos o servicios web), o cualquier operación que pueda 
            llevar un tiempo considerable, es un buen candidato para usar LongRunning.
             */
        }, TaskCreationOptions.LongRunning);

        await task;
        Console.WriteLine("Tarea completada.");
 /*
La ultima línea se muestra antes de que la tarea se complete. 
  Esto ocurre porque el método Task.Factory.StartNew inicia la tarea de manera asíncrona, pero 
  el programa no espera que la tarea finalice antes de continuar con el resto del código.
  Para resolverlo podemos usar await para hacer una estructura totalmente asincronica indicándole 
  al programa que debe esperar a que la tarea se complete para mostrar la ultima línea 
  */
  //LINK GITHUB:https://github.com/Dakootruco/Program-paralela/blob/main/Program.cs
    }
}
