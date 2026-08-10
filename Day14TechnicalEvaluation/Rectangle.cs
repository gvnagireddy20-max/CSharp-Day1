class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override double Area
    {
        get
        {
            return Length * Width;
        }
    }
}