//using System;
//namespace GenericsDemo
//{
//    public class ClsMain
//    {
//        private static void Main()
//        {
//            bool IsEqual = ClsCalculator.AreEqual(10, 20);
//            bool IsEqual1 = ClsCalculator.AreEqual("ABC", "ABC");

//            if (IsEqual)
//            {
//                Console.WriteLine("Both are Equal");
//            }
//            else
//            {
//                Console.WriteLine("Both are Not Equal");
//            }
//            Console.ReadKey();
//        }
//    }

//    public class ClsCalculator
//    {
//        //Now this method can accept any data type
//        //public static bool AreEqual(int value1, int value2)
//        //{
//        //    return value1 == value2;
//        //}
//        //public static bool AreEqual(string value1, string value2)
//        //{
//        //    return value1 == value2;
//        //}
//        //public static bool AreEqual(float value1, float value2)
//        //{
//        //    return value1 == value2;
//        //}

//        // when you pass some type to obejct > It does boxing
//        // boxing menas convertring type from value to reference type
//        public static bool AreEqual(object value1, object value2)
//        {
//            return value1 == value2;  // unboxing
//        }
//    }
//}

using System;
namespace GenericsDemo
{
    public class ClsMain
    {
        private static void Main()
        {
            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual = ClsCalculator.AreEqual<string>("ABC", "ABC");
            bool IsEqual = ClsCalculator.AreEqual<double>(10.5, 20.5);

            IsEqual = ClsCalculator.AreEqual<int>(10, 10);

            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.ReadKey();
        }
    }

    public class ClsCalculator
    {
        //public static bool AreEqual(int value1, int value2)
        //{
        //    return value1 == value2;
        //}

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}