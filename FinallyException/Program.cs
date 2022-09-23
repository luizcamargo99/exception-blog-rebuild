
CalculateNumbers(2, 0);

void CalculateNumbers(int numberOne, int numberTwo)
{
    try
    {
        Console.WriteLine(numberOne / numberTwo);
    }
    catch
    {
        Console.WriteLine("Entrou em catch");
    }
    finally
    {
        Console.WriteLine("Entrou em finally");
    }
}