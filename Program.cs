namespace Sum_of_Array_elements_in_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite zeljenu velicinu niza: ");
            int size = int.Parse(Console.ReadLine()); //konverzija vrednosti u integer i citanje sta korisnik upise
            int[] arr = new int[size]; //deklaracija novog niza

            Console.WriteLine("Unesite elemente niza: ");
            for (int i = 0; i < arr.Length; i++)  //arr.Length - cela duzina niza, ispisivanje niza
            {
                arr[i] = int.Parse(Console.ReadLine()); 
            }
            int result = SumOfElements(arr);
            Console.WriteLine("sum={0}", result);

        }

        public static int SumOfElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) //ispis niza
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}