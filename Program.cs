Console.WriteLine("Är det fint väder idag?");
string svar = Console.ReadLine();
if (svar == "j" || svar == "J") {
    Console.WriteLine("Vi går på piknik!");
} else if (svar == "n" || svar == "N") {
    Console.WriteLine("Vi stanar inne och läser en bok.");
} else {
    Console.WriteLine("Jag förstår inte.");
}