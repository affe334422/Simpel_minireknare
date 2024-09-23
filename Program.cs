using System.Formats.Asn1;

double Svar = 0;

Console.WriteLine("simpel Miniräknare. Ge mig två heltal");

Console.WriteLine("Vad vill du göra Addition = +, Subtraktion = -, Multiplikation = *, Divition = /, Upphöjt = up, Svar: ");
string pp = Console.ReadLine();

Console.Write("Heltal 1: ");
string ta = Console.ReadLine();
double tal1 = double.Parse(ta);

Console.Write("Heltal 2: ");
string tal = Console.ReadLine();
double tal2 = double.Parse(tal);



if(pp != "+" || pp != "-" || pp != "*" || pp != "up" || pp != "/"){
    Console.WriteLine("Du skrev inte +, -, *, up eller /");
}

if(pp == "+"){
    Svar = tal1 + tal2;
    Console.WriteLine(Svar);
}

else if(pp == "-"){
    Svar = tal1 - tal2;
    Console.WriteLine(Svar);
}

else if(pp == "*"){
    Svar = tal1 * tal2;
    Console.WriteLine(Svar);
}

else if(pp == "up"){
    Svar = Math.Pow(tal1, tal2);
    Console.WriteLine(Svar);
}

else if(pp == "/" && tal2 != 0){
    Svar = tal1 / tal2;
    Console.WriteLine(Svar);
}

else if(tal2 == 0){
    Console.WriteLine("Det går inta att dividera med 0");
}

