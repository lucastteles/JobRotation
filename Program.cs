1)
    O valor da variável SOMA será 91.

Isso ocorre porque o código está implementando um loop while, que é executado enquanto a variável K for menor que INDICE (13). A cada iteração do loop, a variável K é incrementada em 1 e a variável SOMA é atualizada para SOMA + K.

Portanto, na primeira iteração, K será 1 e SOMA será 1. Na segunda iteração, K será 2 e SOMA será 3 (1 + 2). Na terceira iteração, K será 3 e SOMA será 6 (1 + 2 + 3). E assim por diante, até a décima-terceira iteração, quando K será 13 e SOMA será 91 (1 + 2 + 3 + ... + 13).

No final do loop, a variável SOMA terá acumulado a soma de todos os números inteiros de 1 a 13.




    /***Questão 2***/
2)
using  System;

 class Program
{
    static void Main(string[] args)
    {
        // Informe o número que deseja verificar 
        int numero = 13;

        int anterior = 0;
        int atual = 1;
        int proximo = 0;

        while (proximo < numero)
        {
            proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        if (proximo == numero)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", numero);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", numero);
        }
    }
}

/***Questão 3***/

3)
a) A lógica é adicionar 2 ao elemento anterior. Portanto, o próximo elemento é 9.

b) A lógica é multiplicar por 2 o elemento anterior. Portanto, o próximo elemento é 128.

c) A lógica é elevar ao quadrado o índice do elemento na sequência. Portanto, o próximo elemento é 49.

d) A lógica é adicionar 12 ao elemento anterior. Portanto, o próximo elemento é 100.

e) A lógica é somar os dois elementos anteriores. Portanto, o próximo elemento é 13.

f) A lógica é adicionar o menor número ímpar à soma dos dois elementos anteriores. Portanto, o próximo elemento é 20.


/***Questão 4***/

4)
 A distância percorrida pelo carro até o ponto X será de 110t, enquanto a distância percorrida pelo caminhão será de 80t + 0,083 km (5 minutos em horas, considerando que ele leva mais tempo nos pedágios).

A soma das distâncias percorridas pelos dois veículos será igual a 100km, já que eles se encontram no ponto X:

110t + 80t + 0,083 = 100

190t = 99,917

t = 0,526 horas(ou aproximadamente 31, 5 minutos)

Agora que sabemos quanto tempo levou para os veículos se cruzarem, podemos calcular a distância percorrida por cada um até o ponto X:

Carro: 110 x 0,526 = 57,86 kmCaminhão: 80 x 0,526 + 0,083 = 42,50 km



/***Questão 5***/
5)
using  System;

 class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string:");
        string input = Console.ReadLine();
        string output = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            output += input[i];
        }

        Console.WriteLine("String invertida: {0}", output);
    }
}
