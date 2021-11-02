namespace App.Model;

public interface IPiece
{
    public Point[] LegalMoves { get; }
    public Point Position { get; set; }
    public bool Team { get; set; }
}