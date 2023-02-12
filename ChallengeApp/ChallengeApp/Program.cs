//zadeklarujesz zmienną z imieniem
//zadeklarujesz zmienną z płcią ( dobierz zmienną)
//zadeklarujesz zmieną z wiekiem
///zweryfikujesz dane i wyświeltisz:
///jeden zkomunikatów:
///(1)"Kobieta poniżej  30 lat
///(2)Ewa, lat 33
///(3)Niepełnoletni mężczyzna

string name = "Ewa";
bool male = true;
bool female = false;
var age = 29;
var age2 = 33;
var age3=17;
if(female==false && age<30)
{
    Console.WriteLine("Kobieta poniżej  30 lat");
}
else if  (name == "Ewa" && age2 == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if  (male == true && age3 < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else 
{
    Console.WriteLine("jestem kimś innym");
}

