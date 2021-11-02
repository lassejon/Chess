namespace App.Model;

public class Board
{
    private const int MaxWidthAndHeight = 7;
    private const int MinWidthAndHeight = 0;
    public IPiece[,] This { get; set; }

    public Board(IPiece[,] @this)
    {
        This = @this;
    }
    
    
}