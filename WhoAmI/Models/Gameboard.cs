using Microsoft.AspNetCore.Components;
using System.Linq;
using System.Net.Http.Headers;

namespace Four_In_A_Row.Models;

public class Gameboard
{
    public const int columnCount = 7;
    public const int rowCount = 6;

    public bool playerOneTurn;

    public int[,] places = new int[rowCount, columnCount];
    public bool noWinner;
    public string errorMessage = "";

    public static Player player1 = new() { Id = 1, Name = "Player 1" };
    public static Player player2 = new() { Id = 2, Name = "Player 2" };
    public Player player = player1;
    public bool turn = false;

    public bool Draw()
    {
        for (int row = 0; row < rowCount; row++)
        {
           
            for (int column = 0; column < columnCount; column++)
            {
                var place = places[row, column];
                if (place == 0)
                    return false;
            }
        }
        return true;
    }

    public void ChangeName(Player player, string name)
    {
        turn = false;
        if(player == player1)
        {
            player1.Name = name;
        }else
            player2.Name = name;
        return;
    }

    public void Turn(int column)
    {
        turn = true;
        var fullColumn = true;
        for (int row = rowCount - 1; row >= 0; row--)
        {

            var place = places[row, column];
            if (place == 0)
            {
                fullColumn = false;
                places[row, column] = player.Id;
                break;
            }

        }
        if (fullColumn) errorMessage = "Sorry deze kolom is vol.";
        else errorMessage = "";
    }
    public int Winner()
    {
        for (int row = 0; row < rowCount; row++)
        {
            int lastPlace = 0;
            int horizontalCount = 1;
            for (int column = 0; column < columnCount; column++)
            {
                var place = places[row, column];
                if (place != 0 && place == lastPlace) horizontalCount++;
                else horizontalCount = 1;
                if (horizontalCount == 4)
                {
                    return place;
                }
                lastPlace = place;
            }
        }

        for (int column = 0; column < columnCount; column++)
        {
            int verticalCount = 1;
            var lastPlace = 0;
            for (int row = 0; row < rowCount; row++)
            {
                var place = places[row, column];
                if (place != 0 && place == lastPlace) verticalCount++;
                else verticalCount = 1;
                if (verticalCount == 4)
                {
                    return place;
                }
                lastPlace = place;
            }
        }



        int possibleColumn = columnCount - 4;
        int possibleRow = rowCount - 4;


        for (int i = 1; i <= possibleRow; i++)
        {
            int lastPlace = 0;
            int diagonalcount = 1;
            int row = i;
            for (int column = columnCount - 1; column >= possibleRow; column--)
            {
                for (; row < rowCount;)
                {
                    var place = places[row, column];
                    if (place != 0 && place == lastPlace) diagonalcount++;
                    else diagonalcount = 1;
                    if (diagonalcount == 4)
                    {
                        return place;
                    }
                    lastPlace = place;

                    row++;
                    break;
                }
            }


        }
        //diagonaal recht links /

        for (int i = possibleColumn; i < columnCount; i++)
        {
            int lastPlace = 0;
            int diagonalcount = 1;
            int column = i;

            for (int row = 0; row < rowCount; row++)
            {

                for (; column >= 0;)
                {
                    var place = places[row, column];
                    if (place != 0 && place == lastPlace) diagonalcount++;
                    else diagonalcount = 1;
                    if (diagonalcount == 4)
                    {
                        return place;
                    }
                    lastPlace = place;

                    column--;
                    break;
                }

            }


        }
        //diagonaal links rechts \
 

        for (int i = 1; i <= possibleRow; i++)
        {
            int lastPlace = 0;
            int diagonalcount = 1;
            int row = i;
            for (int column = 0; column <= columnCount; column++)
            {
                for (; row < rowCount;)
                {
                    var place = places[row, column];
                    if (place != 0 && place == lastPlace) diagonalcount++;
                    else diagonalcount = 1;
                    if (diagonalcount == 4)
                    {
                        return place;
                    }
                    lastPlace = place;
                    row++;
                    break;
                }
            }
        }
        for (int i = 0; i <= possibleColumn; i++)
        {
            int lastPlace = 0;
            int diagonalcount = 1;
            int column = i;

            for (int row = 0; row < rowCount; row++)
            {

                for (; column < columnCount;)
                {
                    var place = places[row, column];
                    if (place != 0 && place == lastPlace) diagonalcount++;
                    else diagonalcount = 1;
                    if (diagonalcount == 4)
                    {
                        return place;
                    }
                    lastPlace = place;
                    column++;
                    break;
                }

            }
        }

      if(turn)  player = (player == player1 ? player2 : player1);
        return 0;
    }

   
    public int Score(Player player)
    {
        if (player == player1)
           return player1.Score++;
        else
           return player2.Score++;
    }
    public void Restart()
    {
        places = new int[rowCount, columnCount];
        noWinner = false;
    }
    public void Reset()
    {
        Restart();
        player1.Score = 0;
        player2.Score = 0;
    }
  
}
