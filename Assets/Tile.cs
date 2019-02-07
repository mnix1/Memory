public class Tile
{
    public Back Back { get; set; }
    public Wisie Wisie { get; set; }
    public int Row { get; }
    public int Col { get; }
    public TileState State { get; set; }

    public Tile(int row, int col)
    {
        this.State = TileState.BACK;
        this.Row = row;
        this.Col = col;
    }

    public void ChangeSide()
    {
        if (State == TileState.BACK)
        {
            State = TileState.HEAD;
        }
        else if (State == TileState.HEAD)
        {
            State = TileState.BACK;
        }
    }

    public override string ToString()
    {
        return $"{Row};{Col};{Wisie.GetName()}";
    }
}
