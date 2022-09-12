
ExceptionWithTryCatch("");
ExceptionWithTryCatch("Luiz Camargo");

void ExceptionWithTryCatch(string name)
{
    try
    {
        ValidateField(name);
        Console.WriteLine($"Valor preenchido - {name}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

void ValidateField(string name)
{
    if (string.IsNullOrEmpty(name))
    {
        throw new ArgumentException("O campo não pode estar vazio", nameof(name));
    }
}