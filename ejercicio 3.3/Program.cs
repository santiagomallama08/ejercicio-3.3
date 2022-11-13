namespace lapices
{
    class lapices
    {
        static void Main()
        {
            double cantidad, precio, total;
            Console.WriteLine("ingrese la cantidad de lapices");
            cantidad = double.Parse(Console.ReadLine());
            if (cantidad >= 1000) ;
            {
                precio = 85;
                total = (cantidad * precio);
            }
            if (cantidad < 1000) ;
            {
                precio = 90;
                total = (cantidad * precio);
            }
            Console.WriteLine($"el costo total de los lapices es de {total}");
        }
    }
}