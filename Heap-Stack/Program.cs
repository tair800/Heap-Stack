// Task 1
int N = 3;
int M = 10;
int SumOddBetweenNM = SumOfOddNumbersBetween(N, M);
Console.WriteLine($"Sum of odd numbers between {N} and {M}: {SumOddBetweenNM}");

// Task 2
int[] Array1 = { 1, 2, 3, 4, 5 };
int SumOddInArray = SumOfOddNumbersInArray(Array1);
Console.WriteLine($"Sum of odd numbers in array: {SumOddInArray}");

// Task 3
int[] Array2 = { 1, 2, 3, 4, 5, 6 };
int CountEvenInArray = CountEvenNumbersInArray(Array2);
Console.WriteLine($"Count of even numbers in array: {CountEvenInArray}");

// Task 4
int Number = 17;
string PrimeOrComposite = IsPrimeOrComposite(Number);
Console.WriteLine($"{Number} is {PrimeOrComposite}");

// Task 5
int NValue = 16;
bool IsPowerOfTwo = IsPowerOfTwo(NValue);
Console.WriteLine($"{NValue} is a power of 2: {IsPowerOfTwo}");

// Task 6
int[] Array3 = { 1, 3, 55, 6, 33 };
int ProductInRange = ProductOfElementsInRange(Array3, 1, 20);
Console.WriteLine($"Product of elements in range 1-20: {ProductInRange}");

// Task 7
int[] Array4 = { 2, 4, 6 };
int SquareOfEvenSum = SquareOfSumOfEvenNumbers(Array4);
Console.WriteLine($"Square of the sum of even numbers in array: {SquareOfEvenSum}");

// Task 8
int[] Array5 = { -1, 2, -3, 4, -5 };
int[] PositiveArray = ConvertNegativeToPositive(Array5);
Console.WriteLine("Array with negatives converted to positives: " + string.Join(", ", PositiveArray));
    }

    static int SumOfOddNumbersBetween(int N, int M)
{
    int Sum = 0;
    for (int I = N; I <= M; I++)
    {
        if (I % 2 != 0)
        {
            Sum += I;
        }
    }
    return Sum;
}

static int SumOfOddNumbersInArray(int[] Array)
{
    return Array.Where(X => X % 2 != 0).Sum();
}

static int CountEvenNumbersInArray(int[] Array)
{
    return Array.Count(X => X % 2 == 0);
}

static string IsPrimeOrComposite(int Number)
{
    if (Number < 2)
    {
        return "not prime";
    }
    for (int I = 2; I <= Math.Sqrt(Number); I++)
    {
        if (Number % I == 0)
        {
            return "composite";
        }
    }
    return "prime";
}

static bool IsPowerOfTwo(int N)
{
    if (N < 1) return false;
    while (N % 2 == 0)
    {
        N /= 2;
    }
    return N == 1;
}

static int ProductOfElementsInRange(int[] Array, int Min, int Max)
{
    return Array.Where(X => X >= Min && X <= Max).Aggregate(1, (Prod, Next) => Prod * Next);
}

static int SquareOfSumOfEvenNumbers(int[] Array)
{
    int SumEven = Array.Where(X => X % 2 == 0).Sum();
    return SumEven * SumEven;
}

static int[] ConvertNegativeToPositive(int[] Array)
{
    return Array.Select(X => Math.Abs(X)).ToArray();
}