using Algoritms_;

namespace AplicandoPLJaMerxLabiofam_
{
    public class Ejecutable
    {
        static void Main()
        {
            int cardinality = 10;

            List<int> list1 = new List<int>() { 0 };
            List<int> list2 = new List<int>() { 1, 2, 3, 4 };
            List<int> list3 = new List<int>() { 5 };
            List<int> list4 = new List<int>() { 6, 7, 8, 9 };

            List<(List<int>, List<int>)> dependecies = new List<(List<int>, List<int>)>() { (list1, list2), (list3, list4)};
            PLJ plj = new PLJ();
            plj.Satisfy(cardinality, dependecies);
        }
    }
}