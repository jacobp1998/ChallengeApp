

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();          // lista


        public Employee(string name, string surname, int age) //konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get; private set; }  //propercja 1 
        public string Surname { get; private set; }  //propercja 2 
        public int Age { get; private set; }  // propercja 3 



        public void AddScore(int number)  //metoda  1
        {
            this.score.Add(number);
        }


        public int Result   //metoda  2 
        {
            get
            {
                return this.score.Sum();
            }
        }
    }
}
