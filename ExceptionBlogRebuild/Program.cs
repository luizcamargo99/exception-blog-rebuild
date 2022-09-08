
ExceptionDivideByZeroWithTryCatch();

//void ExceptionDivideByZeroWithTryCatch()
//{
//    try
//    {
//        PrintDivisionByZero();
//    }
//    catch
//    {
//        Console.WriteLine("Ocorreu um erro");
//    }

//}

void ExceptionDivideByZeroWithTryCatch()
{
    try
    {
        PrintDivisionByZero();
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Entrou no DivideByZeroException");
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
