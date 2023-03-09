using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public  Fraction( int top)
    {    _top = top;   
        _bottom = 1;
    }
    public  Fraction( int tp, int bt)
    {    _top = tp;   
        _bottom = bt;
    }  

    public int GetTop()
    {
        return _top;

    }
    public void SetTop(int tpNumb)
    {
        _top = tpNumb;
        
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int btNumb)
    {
        _bottom = btNumb;
    }
     public override string ToString()
    {
        return _top + "/" + _bottom;

    }
    public double GetDecimalValue()
    {
        return (double) _top / (double)_bottom;

    } 

    //  public string GetFirstName()
    // {
    //     return _firstName;
    // }

    // public void SetFirstName(string firstName)
    // {
    //     _firstName = firstName;
    // }
}

