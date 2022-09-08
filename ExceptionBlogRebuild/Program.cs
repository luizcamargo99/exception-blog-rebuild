
ExceptionDivideByZeroWithTryCatch();


void ExceptionDivideByZeroWithTryCatch()
{
    try
    {
        PrintDivisionByZero();
    }
    catch
    {
        Console.WriteLine("Ocorreu um erro");
    }

}

void PrintDivisionByZero()
{
    var numberOne = 10;
    var numberTwo = 0;
    Console.WriteLine(numberOne / numberTwo);
}
