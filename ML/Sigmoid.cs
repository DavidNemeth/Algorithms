public double Sigmoid(double x)
{
    return 1 / (1 + Math.Exp(-x));
}

public double Derivative(double x)
{
    double s = Sigmoid(x);
    return s * (1 - s);
}
