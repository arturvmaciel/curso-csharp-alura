string nome = "Artur";
string agradecimento = "\nObrigado pelo feedback!";

void Resultados()
{
    float a = 4;
    float b = 8;
    float soma = a + b;
    float subtracao = a - b;
    float multiplicacao = a * b;
    float divisao = a / b;

    Console.WriteLine($"\nA soma de {a} e {b} é {soma}");
    Console.WriteLine($"\nA subtração de {a} e {b} é {subtracao}");
    Console.WriteLine($"\nA multiplicação de {a} e {b} é {multiplicacao}");
    Console.WriteLine($"\nA divisão de {a} e {b} é {divisao}");
}
void ExibirMensagemFeedback()
{
    Console.WriteLine(agradecimento);
}
    Console.WriteLine($"\nBem-vindo(a): {nome} ");
Resultados();
ExibirMensagemFeedback();