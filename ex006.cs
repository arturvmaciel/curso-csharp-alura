List<int> numeros = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
// utilizando o "for"
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // verifica se o número é par
    {
        Console.WriteLine(numeros[i]);
    }
}
// utilizando o "foreach"
/*foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
    }
}*/