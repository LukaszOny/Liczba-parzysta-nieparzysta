Console.WriteLine("Wprowadż dowolną liczbę, aby sprawdzić czy jest ona parzystą");
int a = Int32.Parse(Console.ReadLine());

if (a%2 == 0)
{
    Console.WriteLine($"Liczba {a} jest liczbą parzystą");

}
else
{
    Console.WriteLine($"Liczba {a} jest liczbą nieparzystą");
}

