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
    }
}