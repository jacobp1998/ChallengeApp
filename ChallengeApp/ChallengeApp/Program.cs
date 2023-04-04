// klasy, to struktury, które są przygotowane aby obsługiwać powtarzające się modele danych
//np. użytkowanik danego systemu (ma swój login, hasło)
//np. raport 
//książka w magazynie, zamówienie w sklepie
//User user1=new User();  var user1 = new User();
//User user2= new User(); var user2 = new User();
//User user3= new User(); var user3 = new User();
//User user4= new User(); var user4 = new User();

//user1.login = "Jakub";
//user1.password
//class User
//{
   // public string login;
   // public string password;
   // private string name;
//}

// public i private - modyfikatory dostępu.
//private - coś czego nie można zmienić np. imię; jeśli nie ma napisane private to i tak jest to domyślnie private.




//KONSTRUKTORY: dodatkowe miejsce, które jest wywoływane w momencie, gdy tworzony jest dany obiekt.





    //02.04.2023

    User user1= new User("Adam", "456456456");
    User user2= new User("Monika", "456456456");  
    User user3= new User("Zuzia", "456456456");  
    User user4= new User("Damian", "456456456");


//user1.Login = "Marek";  //ctrl+spacja (podpowiedź) pojawia się Login 
var name = user1.Login;

user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;
class User                     //klasa
{

    public static string GameName = "Diablo";            //obiekt statyczny, można bezpośrednio działać na nim , bez tworzenia obiektu User typu user1.

    private List <int> score = new List<int>();                //zmienna, którą lokalnie przechowywujemy
   
    public User(string login, string password)      //konstruktor
    {
        this.Login = login;
        this.Password = password;
        
    }

    

    public string Login { get; private set; }             //propercja (pola) 1


    public string Password { get; private set; }  //propercja(pole) 2 



    public int Result                               //METODA 
    {
        get
        {
            return this.score.Sum();
        }
    }


    public void AddScore(int number )               //METODA
    {
        this.score.Add(number);
    }

}













