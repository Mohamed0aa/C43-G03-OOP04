namespace Demo
{
    internal class Program
    {
        static void print(Iseries seriesss)
        {
            for (int i = 0; i < 10; i++)
            {
                seriesss.get_next();
                Console.WriteLine(seriesss.current);
            }
            seriesss.reset();
            Console.WriteLine( seriesss.current);
        }
        static void Main(string[] args)
        {
            #region vedio 1  interface ex1
            //    Itype refrence=new typeA();
            //refrence.myproperty = 33;
            //refrence.method1();
            //refrence.method();
            #endregion

            #region vedio 2 interface ex2
            Series seriesby2 =new Series();
            print(seriesby2);
            #endregion

        }
    }
}
