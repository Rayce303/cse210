class Shape
{
    protected string _color;
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string woohoo)
    {
        _color = woohoo;
    }

    public virtual double GetArea()
    {
        return 1.0;
    }
}