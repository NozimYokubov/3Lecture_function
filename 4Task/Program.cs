void FillArray = (int[] arr )
{
    for (int i = 0; i < arr.Length; i++)
    {
    arr[i] = i + 1;
}
}

int PrintArray = (int[] arr)
{
    foreach (var e in arr)
    {
        Console.Write($"{e} ");
    }
}

int GetSumOfElements = (int[] arr) 
{
    for ( i = 0; i < arr.Length; i++)
    {
    int sum = sum + arr[i];
}
}

int GetProductOfElements = (int[] arr) 
{
    for ( i = 0; i < arr.Length; i++)
    {
    int product = product * arr[i];
    }
}


int n = 10;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);