// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int n  = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int sum = 0;
int[,] array = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if(i ==0 || j == 0)
        {
            array[i, j] = 1;
        }
        else
        {
            array[i, j] = array[i - 1, j] + array[i, j - 1];
            
        }

    }
}
Console.WriteLine(array[n-1,m-1]);