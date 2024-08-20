namespace ASS1
{
    internal class Program
    {
        #region method
        //static var Print(var X)
        //{
        //    return X;
        //} 
        #endregion

        static void Main()
        {
            #region var
            // C# Keywords: Implicitly Typed Local Variable [var – dynamic]
            // var

            //var Data01 = "Ahmed";

            // Compiler Will Detect Datatype Of Local Variable Based On Initial Value, At Compilation Time
            // Must Be Initialized
            // Can't Initialize Local Variable With Null
            // Can't Change Datatype Of The Local Variable After Initialization

            // var X = 12; // Valid
            // var X; // Invalid
            // var X = null; // Invalid 
            #endregion

            #region C# Keywards
            //int number = 12345;
            //var result =intExtention.Reverse(number);
            //Console.WriteLine(result);
            #endregion

            #region var emp
            //var emp =new { ID =1 , Name ="mohsen", salary =1200};
            //Console.WriteLine(emp);
            //var emp2 = emp;
            //Console.WriteLine(emp2);
            //if(emp.Equals(emp2))
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("!equals")
            //} 
            #endregion

            #region linq
            #region fluent syntax
            //List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = Enumerable.Where(number, n => n % 2 == 0);
            //foreach (int n in result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region query syntax
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = from n in list
            //             where n % 2 == 0
            //             select n;
            //foreach (var n in result)
            //{
            //    Console.WriteLine(n);
            //} 
            #endregion

            #region differd way
            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //var result = Enumerable.Where(list,n=> n%2==0);
            //list.AddRange(new[] { 11, 12, 13, 14, 15, });
            //foreach(var item in result)
            //    Console.WriteLine(item+"  ");
            #endregion
            #region immediate way
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var result = Enumerable.Where(list, n => n % 2 == 0).ToList();
            //list.AddRange(new[] { 11, 12, 13, 14, 15, });
            //foreach (var item in result)
            //    Console.WriteLine(item + "  ");
            #endregion


            #endregion

            Console.WriteLine(ListGenerator.ProductsList[0]);

        }
    }
}