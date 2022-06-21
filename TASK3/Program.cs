void setArray()
{
    int[] arrA = new int[8];
    int i = 0;
    for (i = 0; i < 8; i++)
    {
        Random rnd = new Random();
        arrA[i] = rnd.Next(100,1000);
        Console.Write($" {arrA[i]} |");
    }
}
setArray();