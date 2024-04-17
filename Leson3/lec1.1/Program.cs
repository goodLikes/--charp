double CalculateFormula(int a, int b, int c, int d)
{
  int numenator = a * b;
  double dominator = c + d;
  double result = numenator / dominator;
  return result;
}

CalculateFormula(1, 2, 3, 4);

double answer = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(answer);
