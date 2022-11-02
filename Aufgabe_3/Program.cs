float kaltmiete;
float nebenkosten;
float warmmiete;
float quadratmeter;

Console.WriteLine("Kaltmiete:");
kaltmiete = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Nebenkosten:");
nebenkosten = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Quadratmeter des Objekts:");
quadratmeter = Convert.ToSingle(Console.ReadLine());

Console.WriteLine($"{"Kaltmiete/m^2:",-30}{kaltmiete:F2} EUR");
Console.WriteLine($"{"Nebenkosten/m^2:",-30}{nebenkosten:F2} EUR");
Console.WriteLine($"{"Quadratmeter des Objekts:",-30}{quadratmeter} m^2\n");

kaltmiete = kaltmiete * quadratmeter;
nebenkosten = nebenkosten * quadratmeter;
warmmiete = nebenkosten + kaltmiete;

Console.WriteLine($"{"Kaltmiete:",-30}{kaltmiete:F2} EUR");
Console.WriteLine($"{"Nebenkosten:",-30}{nebenkosten:F2} EUR");
Console.WriteLine($"{"Warmmiete:",-30}{warmmiete:F2} EUR");