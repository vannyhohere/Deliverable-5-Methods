/* Name: Vanny Ho  
 * Date: 2/16/2023
 * Deliverable 5 - Methods
 */ 



namespace Deliverable_5___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr;  // declare array variable

            try
            {
                Console.Write("Enter an integer number between 5 and 15: ");
                int size = Convert.ToInt32(Console.ReadLine());

                // check user's entry is between 5 and 15
                if (size >= 5 && size <= 15)
                {
                    // populate array with random integers between 10 and 50
                    arr = PopulateArray(size);
                    Console.WriteLine("The elements of the arrays are: ");
                    DisplayArray(arr);

                    // calculate summation of array elements
                    int sum = ArraySum(arr);
                    Console.WriteLine("The sum is: " + sum);
                }
                else
                {
                    Console.WriteLine("Error: Invalid input. Number must be between 5 and 15.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer number.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        // method to populate an array with random integers between 10 and 50
        static int[] PopulateArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(10, 51);
            }
            return arr;
        }

        // method to display all the elements in the array
        static void DisplayArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // method to calculate the summation of all elements in the array
        static int ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }
    }
}