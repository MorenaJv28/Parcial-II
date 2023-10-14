//EJERCICIO 3


DateTime FF = new DateTime(2023, 11, 18, 15, 0, 0);

DateTime Fecha = DateTime.Now;

TimeSpan DR = FF - Fecha;
int DF = (int)DR.TotalDays;

string F1 = Fecha.ToString("dd/MM/yyyy");
string F2 = Fecha.ToString("dd MMM yyyy");
string F3 = Fecha.ToString("yyyy MMM dd");
Console.WriteLine();
Console.WriteLine("Finalizacizaciòn de Actividades Academicas");
Console.WriteLine();
Console.WriteLine("Fecha y hora del dia de hoy : " + Fecha);
Console.WriteLine();
Console.WriteLine("Timpo restante para el parcial: " + DF + " días");
Console.WriteLine();
Console.WriteLine("Forma 1: " + F1);
Console.WriteLine("Forma 2: " + F2);
Console.WriteLine("Forma 3: " + F3);
