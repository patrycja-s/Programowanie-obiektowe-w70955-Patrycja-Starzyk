﻿public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Rysowanie kształtu...");
    }
}
