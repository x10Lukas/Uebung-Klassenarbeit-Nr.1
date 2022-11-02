double gewicht;
double größe;
double bmi;

Console.WriteLine("Geben Sie Ihr Gewicht an:");
gewicht = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Geben Sie Ihre Größe an:");
größe = Convert.ToDouble(Console.ReadLine());

bmi = gewicht / (größe * größe);

Console.WriteLine($"BMI = {bmi}");