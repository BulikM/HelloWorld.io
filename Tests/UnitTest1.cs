using Four_In_A_Row.Models;

namespace Tests;

[TestClass]
public class UnitTest1
{
    private Gameboard gameboard;
    [TestInitialize]
    public void Initialize()
    {
        gameboard = new Gameboard();
    }
    [TestMethod]
    public void horizontalFourInARowPlayer1Wins()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
           { 1, 1, 1, 1, 0, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 },
           { 0, 0, 2, 2, 2, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 }
         };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    public void horizontalFourInARowPlayer2Wins()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
           { 1, 1, 1, 0, 0, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 },
           { 0, 0, 2, 2, 2, 2, 0 },
           { 0, 0, 0, 0, 0, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 },
           { 0, 0, 0, 0, 0, 0, 0 }
         };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void horizontale4OpEenRijInTweeRijenIsFout()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsFalse(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void verticale4OpEenRij()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
    
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void verticale4OpEenRijOpMeerdereRijenIsFout()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 }
     

        };

        Assert.IsFalse(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts1()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 2, 0, 0, 0, 0, 0, 0 },
            { 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts2()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts3()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 2, 0, 0, 0, 0, 0, 0 },
            { 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts4()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts5()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts6()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 2, 0, 0, 0, 0, 0, 0 },
            { 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts7()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0 },
            { 0, 0, 0, 0, 0, 0, 2 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijLinksRechts8()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void Diagonale4OpEenRijLinksRechts9()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 2, 0, 0, 0, 0, 0 },
            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void Diagonale4OpEenRijLinksRechts10()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0 },
            { 0, 0, 0, 0, 0, 0, 2 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void Diagonale4OpEenRijLinksRechts11()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 2, 0, 0, 0, 0 },
            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void Diagonale4OpEenRijLinksRechts12()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 2, 0, 0, 0 },
            { 0, 0, 0, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0 },
            { 0, 0, 0, 0, 0, 0, 2 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 2);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks1()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {

            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 }

        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks2()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 }           
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks3()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks4()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks5()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks6()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks7()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks8()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks9()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks10()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks11()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijRechtsLinks12()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 1, 0, 0, 0 },
            { 0, 0, 1, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsTrue(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void diagonale4OpEenRijInMeerdereDiagonalenIsFout()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 0, 0, 0, 0, 0, 1, 0 },
            { 0, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
        };

        Assert.IsFalse(gameboard.Winner() == 1);
    }
    [TestMethod]
    public void gelijkspel()
    {
        gameboard.places = new int[Gameboard.rowCount, Gameboard.columnCount]
        {
            { 2, 2, 1, 1, 2, 2, 1 },
            { 2, 2, 1, 1, 2, 2, 1 },
            { 1, 1, 2, 2, 1, 1, 2 },
            { 1, 1, 2, 2, 1, 1, 2 },
            { 2, 2, 1, 1, 2, 2, 1 },
            { 2, 2, 1, 1, 2, 2, 1 }
        };

        Assert.IsTrue(gameboard.Draw());
    }
}