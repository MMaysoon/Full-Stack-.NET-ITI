namespace Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OddSeries odd_1 = new OddSeries();
            OddSeries odd_2 = new OddSeries();
            OddSeries odd_3 = new OddSeries();
            OddSeries odd_4 = new OddSeries();

            EvenSeries even_1 = new EvenSeries();
            EvenSeries even_2 = new EvenSeries();
            EvenSeries even_3 = new EvenSeries();
            EvenSeries even_4 = new EvenSeries();

            SeriesEnginee enginee = new SeriesEnginee();


            Console.WriteLine("--------" + odd_3.ToString() + "--------");
            enginee.PrintCurrentSeriesValue(odd_1);
            enginee.PrintCurrentSeriesValue(odd_2);
            enginee.PrintCurrentSeriesValue(odd_3);
            enginee.PrintCurrentSeriesValue(odd_4);


            Console.WriteLine("--------" + even_1.ToString() + "--------");
            enginee.PrintCurrentSeriesValue(even_1);
            enginee.PrintCurrentSeriesValue(even_2);
            enginee.PrintCurrentSeriesValue(even_3);
            enginee.PrintCurrentSeriesValue(even_4);
        }
    }
}
