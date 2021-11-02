namespace App.Model;

public class Knight : IPiece
{
    public Point[] LegalMoves { get; }
    public Point Position { get; set; }
    public bool Team { get; set; }

    public Knight(int x, int y, bool team)
    {
        Position = new Point(x, y);
        Team = team;
        
        LegalMoves = new[]
        {
            new Point(1, 2),
            new Point(2, 1),
            new Point(-1, 2),
            new Point(-2, 1),
            new Point (-1, -2),
            new Point(-2, -1),
            new Point(1, -2),
            new Point(2, -1)
        };
    }
}