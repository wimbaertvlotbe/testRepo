public double Gemiddelde(double[] metingen)
{
	'double gemiddelde = 0;
double som = 0;

foreach (double m in meting)
{
som += m;
}
gemiddelde = som / meting.Length;
return gemiddelde;`
}
