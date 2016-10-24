public double Sigmoid(double x)
{
    return 2 / (1 + Math.Exp(-2 * x)) - 1;
}
