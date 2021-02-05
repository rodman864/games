using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanUserBeAttacked_IfItsGamer_ReturnsTrue()
        {
            //Arrange
            MyGame myGame = new MyGame();

            User newUser = new User();
            newUser.IsGamer = true;
            newUser.UserName = "Rodrigus";

            Clan newClan = new Clan();
            newClan.ClanName = "The Best";
            newUser.ClanInfo = newClan;
            myGame.CurrentUser = newUser;

            //Act
            User newEnemy = new User();
            newEnemy.IsGamer = true;
            newEnemy.UserName = "Amos";

            Clan newEnemyClan = new Clan();
            newEnemyClan.ClanName = "SU Guys";
            newEnemy.ClanInfo = newEnemyClan;

               
           bool canItBeAttacked =
                myGame.CanUserBeAttacked(newEnemy);

            //Assert
            Assert.IsTrue(canItBeAttacked);
        }
    }
}
