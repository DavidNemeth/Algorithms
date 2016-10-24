public double Sigmoid(double x)
{
    return 1 / (1 + Math.Exp(-x));
}

public double Derivative(double x)
{
    double s = Sigmoid(x);
    return s * (1 - s);
}

 private static int MaxIndex(double[] vector) // helper for Accuracy()
 {
     // index of largest value
     int bigIndex = 0;
     double biggestVal = vector[0];
     for (int i = 0; i < vector.Length; ++i)
     {
         if (vector[i] > biggestVal)
         {
             biggestVal = vector[i];
             bigIndex = i;
         }
     }
     return bigIndex;
 }
