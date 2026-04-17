int[] a = {10, 25, 15};
int l= a[0];
for  (int i = 1;i<a.Length; i++)
{
    if (a[i] > l)
    {
        l = a[i];
    }
    Console.WriteLine(l);
    break;
}
Console.WriteLine(a.Max());