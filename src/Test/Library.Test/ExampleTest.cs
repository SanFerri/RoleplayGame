using NUnit.Framework;

namespace Test.Library
{


    public class ExampleTest
    {
        Undead Anubis = new Undead("Anubis", 10, 10);

        [Test]
        public void dummyTest()
        {
            Assert.True(true);
        }

        [Test]
        public void damagetest()
        {
            int postdamagedhealth = 5
            Anubis.Damaged(5);
            Assert.True(postdamagedhealth = Anubis.health);
        }
        [Test]
        public void healtest()
        {
            int postheal_health = 10
            Anubis.Damaged(5);
            Anubis.Heal();
            Assert.True(postheal_health = Anubis.health);
        }
    }


}