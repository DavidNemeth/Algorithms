public double Sigmoid(double x)
{
    return 2 / (1 + Math.Exp(-2 * x)) - 1;
}

public double Derivative(double x)
{
    double s = Sigmoid(x);
    return 1 - (Math.Pow(s, 2));
}
