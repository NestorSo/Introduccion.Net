Console.WriteLine("**Calcular importe y descuento**");

Console.WriteLine(" ");
double cantidad, precio;

Console.WriteLine("Digite la cantidad de productos que lleva");
cantidad = double.Parse(Console.ReadLine());
Console.WriteLine("Digite el precio de los productos");
precio = double.Parse(Console.ReadLine());

double importe = cantidad * precio;
double descuento = importe * 0.11;
double total = importe - descuento;

Console.WriteLine("El importe por los productos es: " + importe.ToString("0.00"));
Console.WriteLine("EL decuento por los productos es: " + descuento.ToString("0.00"));
Console.WriteLine("El total a ppagar es de: " + total.ToString("0.00"));
