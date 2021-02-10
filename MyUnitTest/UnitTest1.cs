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
        [TestMethod]
        public void DidEnemyWin_IfEnemyWin_ReturnFalse()
        {
            //Arrange
            MyGame enemy = new MyGame();

            User newEnemy = new User();
            newEnemy.IsGamer = true;
            newEnemy.UserName = "Amos";

            Clan enemyClan = new Clan();
            enemyClan.ClanName = "The Worst";
            newEnemy.ClanInfo = enemyClan;
            enemy.CurrentUser = newEnemy;

            //Act
            User winner = new User();
            winner.IsGamer = true;
            winner.UserName = "Rodrigus";

            Clan newEnemyClan = new Clan();
            newEnemyClan.ClanName = "Rodrigus";
            newEnemy.ClanInfo = newEnemyClan;


            bool DidEnemyWin =
                 enemy.DidEnemyWin(newEnemy);

            //Assert
            Assert.IsFalse(DidEnemyWin);


        }
        [TestMethod]
        public void DidEnemyPunch_IfEnemyPunch_ReturnTrue()
        {
            //Arrange
            MyGame enemy = new MyGame();

            User newEnemy = new User();
            newEnemy.IsGamer = true;
            newEnemy.UserName = "Amos";

            Clan enemyClan = new Clan();
            enemyClan.ClanName = "The Worst";
            newEnemy.ClanInfo = enemyClan;
            enemy.CurrentUser = newEnemy;

            //Act
            User winner = new User();
            winner.IsGamer = true;
            winner.UserName = "Rodrigus";

            Clan newEnemyClan = new Clan();
            newEnemyClan.ClanName = "Rodrigus";
            newEnemy.ClanInfo = newEnemyClan;


            bool DidEnemyPunch =
                 enemy.DidEnemyPunch(newEnemy);

            //Assert
            Assert.IsFalse(DidEnemyPunch);


        }
        [TestMethod]
        public void KickedEnemy_IfKick_ReturnFalse()
        {
            //Arrange
            MyGame enemy = new MyGame();

            User newEnemy = new User();
            newEnemy.IsGamer = true;
            newEnemy.UserName = "Amos";

            Clan enemyClan = new Clan();
            enemyClan.ClanName = "The Worst";
            newEnemy.ClanInfo = enemyClan;
            enemy.CurrentUser = newEnemy;

            //Act
            User winner = new User();
            winner.IsGamer = true;
            winner.UserName = "Rodrigus";

            Clan newEnemyClan = new Clan();
            newEnemyClan.ClanName = "Rodrigus";
            newEnemy.ClanInfo = newEnemyClan;


            bool KickedEnemy =
                 enemy.KickedEnemy(newEnemy);

            //Assert
            Assert.IsFalse(KickedEnemy);


        }

    }
}

