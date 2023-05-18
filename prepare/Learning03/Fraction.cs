using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction(){
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber){
        // Default 1 in bottom
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        // To receive both parameters 'top' and 'bottom'
        _top = top;
        _bottom = bottom;
    }

    public int GetTop(){
        return _top;
    }

    public void SetTop(int top){
        _top = top;
    }

    public int GetBottom(){
        return _bottom;
    }

    public void SetBottom(int bottom){
        _bottom = bottom;
    }

    public string GetFractionString(){
        string text = _top + "/" + _bottom;
        return text;
    }

    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}