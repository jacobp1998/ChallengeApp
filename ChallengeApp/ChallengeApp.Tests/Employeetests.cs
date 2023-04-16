using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
       

        [Test]
        public void WhenEmployeeGetsScores_ShouldGetCorrectResult()
        {
            //arrange 
            var employee1 = new Employee("Jakub","Gajda",25);
            employee1.AddScore(10);
            employee1.AddScore(0);
            employee1.AddScore(-10);
            //act 

            var result = employee1.Result;

            //assert 

            Assert.AreEqual(0, result);
        }

        
    }


}