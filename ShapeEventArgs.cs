﻿namespace EventsBase;

public class ShapeEventArgs:EventArgs
{

    public ShapeEventArgs(double area)
    {
        NewArea = area;  
    }

    public double NewArea { get; set; }

}
