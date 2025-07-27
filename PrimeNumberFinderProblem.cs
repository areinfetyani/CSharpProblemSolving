using System.Collections.Generic;
using System.Threading.Tasks;

public class PrimeNumberFinderProblem
{
    public static async Task<List<int>> MultiThreadedPrimeFinder()
    {
        Task<List<int>> task = Task.Run(() => 
        {
            List<int> primes = new List<int>();
            for (int i = 2; i <= 1000000; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        });
        return await task;
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        for (int i = 2; i <= Math.Sqrt(n); i++) 
        { 
            if (n % i == 0)
            {
                return false;
            }
        }
    
        return true;
    }
}
