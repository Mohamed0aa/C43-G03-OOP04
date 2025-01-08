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
            //Series seriesby2 =new Series();
            //print(seriesby2);
            #endregion

            #region  vedio 3 ex 3
            //Imovable move=new airplane();

            //Iflayable fly=new airplane();

            //move.backward();
            //fly.backward();
            #endregion

            #region vedio 4 sallow copy &deep copy
            //int[] num = { 1, 2, 3 };
            //int [] arr = { 1, 2,3,4,5,6,7 };

            //num =arr;//shallo copy ({ 1, 2,3,4,5,6,7 } become unreachable object)


            //num= (int[])arr.Clone(); //deep copy which is create new object 

            //clone it make a shallow copy  of array 
            //string[] name1 = { "mo", "ahmed" };
            //string[] name2 = { "smi", "gogo" };
            //name2 = (string[]) name1.Clone();

            //name2[0] = "amr";
            //Console.WriteLine(name1[0]);
            #endregion

        }
    }
}
