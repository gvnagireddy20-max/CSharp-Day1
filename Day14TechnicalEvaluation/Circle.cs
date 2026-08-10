class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area
    {
        get
        {
            return Math.PI * Radius * Radius;
        }
    }
}