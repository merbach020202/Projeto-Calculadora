//vamos criar um calculadora usabdo switch case

//logica - Algoritimo

//1. Definir a operação
//2. Informar o 1 número
//3. Informar o segundo número
//4. Processar os dados inseridos
//5. Exibir o resultado

//entrada

Console.WriteLine(@$"
.....................................................
|                Programa Calculadora               |
|Informe a operação matematica que deseja efetuar:  |
|'+' para somar                                     |
|'-' para subtrair                                  |
|'*' para multiplicar                               |
|'/' para dividir                                   |
....................................................|
");


// recebe a operação escolhida
char operacao = char.Parse(Console.ReadLine());


//entrada do primeiro numero
Console.WriteLine($"digite o primeiro número: ");
float numero1 = float.Parse(Console.ReadLine());


//entrada do segundo numero
Console.WriteLine($"digite o segundo número: ");
float numero2 = float.Parse(Console.ReadLine());


//declarado a variavel que recebera o resultado
float resultado = 8;

//processamento

switch (operacao)
{
    case '+':
    resultado = (numero1 + numero2);
    Console.WriteLine($"O resultado da soma é: {resultado}");
    break;

    case '*':
    resultado = (numero1 * numero2);
    Console.WriteLine($"O resultado da multiplicação é: {resultado}");
    break;

    case '-':
    resultado = (numero1 - numero2);
    Console.WriteLine($"O resultado da subtração é: {resultado}");
    break;

    case '/':
    resultado = (numero1 / numero2);
    Console.WriteLine($"O resultado da divisão é: {resultado}");
    break;
    
}



 





