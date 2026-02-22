namespace A_6_2_2_prefix_suffix_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = [1, 2, 3, 4];
            int[] arr2 = [-1, 1, 0, -3, 3];

            Console.WriteLine($"Current Array 1: [{string.Join(", ", arr1)}]");
            PrefixSuffixProduct(arr1);
            Console.WriteLine($"Product Array 1: [{string.Join(", ", arr1)}]\n\n");

            Console.WriteLine($"Current Array 2: [{string.Join(", ", arr2)}]");
            PrefixSuffixProduct(arr2);
            Console.WriteLine($"Product Array 2: [{string.Join(", ", arr2)}]\n\n");
        }


        static void PrefixSuffixProduct(int[] arr)
        {
            int arrSize = arr.Length;
            int[] prefix = new int[arrSize];
            int[] suffix = new int[arrSize];

            int prefixProduct = 1;
            int suffixProduct = 1;

            // Build prefix array
            for (int i = 0; i < arrSize; i++)
            {
                
                if (i == 0)
                {
                    prefix[i] = 1;
                }
                else
                {
                    prefix[i] = prefixProduct * arr[i - 1];
                    prefixProduct = prefixProduct * arr[i - 1];
                }
            }

            // Build suffix array
            for (int j = arrSize - 1; j >= 0; j--)
            {
                if(j == arrSize - 1)
                {
                    suffix[j] = 1;
                }
                else
                {
                    suffix[j] = suffixProduct * arr[j + 1];
                    suffixProduct = suffixProduct * arr[j + 1];
                }
            }

            // Built Result
            for (int k = 0; k< arrSize; k++)
            {
                arr[k] = prefix[k] * suffix[k];
            }


        }
    }
}
