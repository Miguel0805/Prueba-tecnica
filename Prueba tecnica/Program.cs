// See https://aka.ms/new-console-template for more information


const double GRAVEDAD = 9.81;
const double ANGULO = 30;
const double VELOCIDAD_INICIAL = 20.2;
int left = 10;

// Ymax = Vo2Sen2(a) / 2g
double v1 = Math.Pow(VELOCIDAD_INICIAL, 2);
double sen = Math.Pow((Math.Sin(ANGULO)), 2);
double g = (2 * GRAVEDAD);
decimal alturaMaxima = Convert.ToDecimal(((v1 * sen) / (g)));
decimal alcanceHorizontal = Convert.ToDecimal( ( ((Math.Pow(VELOCIDAD_INICIAL, 2)) / GRAVEDAD) * (Math.Pow(Math.Sin(ANGULO), 2)) ) );
//int espacio =
//Console.WriteLine(alturaMaxima);

Console.SetBufferSize(500, 150);

for (decimal i = alturaMaxima; i >=0; i--)
{
    Console.SetCursorPosition(left += 6, Convert.ToInt32(Math.Ceiling(i)));
    Console.WriteLine("*");
}
for (int i = 0; i <= alturaMaxima; i++)
{
    Console.SetCursorPosition(left += 6, i);
    Console.WriteLine("*");
}

Console.ReadLine();

