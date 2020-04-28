namespace Project_Euler
{
    internal class P033
    {
        /*
         * Problem 33: Digit cancelling fractions
         * The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
         * We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
         * There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
         * If the product of these four fractions is given in its lowest common terms, find the value of the denominator.
         */

        public static int Solve()
        {
            int denProd = 1;
            int nomProd = 1;
            for (int d = 11; d <= 99; d++)
            {
                for (int n = 10; n < d; n++)
                {
                    char[] den = d.ToString().ToCharArray();
                    char[] nom = n.ToString().ToCharArray();
                    double f = (double)n / (double)d;
                    if ((den[1] != '0') & (nom[1] != '0'))
                    {
                        int a = 1;
                        int b = 1;
                        double possibleFraction = 0;
                        if (den[0] == nom[1])
                        {
                            a = int.Parse(den[1].ToString());
                            b = int.Parse(nom[0].ToString());
                            possibleFraction = (double)b / (double)a;
                        }
                        else if (den[1] == nom[0])
                        {
                            a = int.Parse(den[0].ToString());
                            b = int.Parse(nom[1].ToString());
                            possibleFraction = (double)b / (double)a;
                        }
                        if (possibleFraction == f)
                        {
                            denProd *= d;
                            nomProd *= n;
                        }
                    }
                }
            }
            for (int i = 2; i <= nomProd; i++)
            {
                while ((nomProd % i == 0) && (denProd % i == 0))
                {
                    nomProd /= i;
                    denProd /= i;
                }
            }
            return denProd;
        }
    }
}