using System;

ExceptionDivideByZeroWithTryCatch();

void ExceptionDivideByZeroWithTryCatch()
{
    try
    {
        PrintDivisionByZero();
    }
    catch (Exception)
    {
        Console.WriteLine("Entrou no Exception");
    }
}

void PrintDivisionByZero()
{
    var numberOne = 10;
    var numberTwo = 0;
    Console.WriteLine(numberOne / numberTwo);
}

