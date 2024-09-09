// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*VARIÁVEIS E CONSTANTES

int variavelDoTipoInteiro = 23;
float variavelDoTipoFloat = 2.34f;
bool variavelDoTipoBooleana = true;
decimal variavelDoTipoDecimal = 45.6m;

int i = 20;
int idade = 20;

const decimal numeroPi = 3.14m;
Console.WriteLine(numeroPi);

numeroPi = 4.5m;

var texto = "olá, senai!";
Console.WriteLine(texto);

VARIÁVEIS E CONSTANTES*/

//COMENTÁRIOS

//Console.WriteLine("olá");
//Console.WriteLine("mundo");

//Console.WriteLine("olá\nmundo");
//Console.WriteLine("olá\tmundo");
//Console.WriteLine("olá\"mundo\"");
//Console.WriteLine("c:\\documentos\\codigos");

//Console.WriteLine(@"Mensagem formatada que termina aqui. ");

//Console.WriteLine(@"c:\documentos\codigos");

//int idade = 20;
//Console.WriteLine("olá tenho " + idade + " anos");
//Console.WriteLine($"olá tenho {idade} anos");

//COMENTÁRIOS

//Console.WriteLine("Hello,World!");

//int valorUM = 10;
//int valorDois = 5;

//Console.WriteLine(valorUM + valorDois);
//Console.WriteLine(valorUM - valorDois);
//Console.WriteLine(valorUM * valorDois);
//Console.WriteLine(valorUM / valorDois);
//Console.WriteLine(valorUM % valorDois);


// Precedência
//float total;

//total = (5 + 4) * 9;
//Console.WriteLine(total);
//Operadores de atribução combinados com alguma operação 

/*float valor = 10;
/*Console.WriteLine(valor +=1); // valor = valor + 1
Console.WriteLine(valor -=2); // valor = valor -2 = 9
Console.WriteLine(valor *=5); // valor = 9 * 5 = 45
Console.WriteLine(valor /=5); // valor = 45 / 5 = 9
Console.WriteLine(valor %=3); // valor = 9 % 3

/*Operadores de incremento e decremento
incremento

valor++; // valor = valor + 1;
Console.WriteLine(valor);
valor++;
Console.WriteLine(valor);

//decremento
valor--; //valor = valor - 1
Console.WriteLine(valor);
valor--;
Console.WriteLine(valor);*/

//operadores relacionais 
/*int a = 4;
int b = 2;

Console.WriteLine(a == b); //false
Console.WriteLine(a != b); //true
Console.WriteLine(a > b); //true
Console.WriteLine(a >= b); //true
Console.WriteLine(a < b); //false
Console.WriteLine(a <= b); //false*/

/*Operadores lógicos
//operaddor && (e)
//operador  || (ou) 

Console.WriteLine(false && true); // false
Console.WriteLine(false && false); // false
Console.WriteLine(true && true); // true

Console.WriteLine(false || true); // true
Console.WriteLine(false || false); // false
Console.WriteLine(true || true); // true*/


/*Estruturas de COntrole*/
// IF

/*int idademinima = 16;
int idadedaclaudia = 15;

if (idadedaclaudia >= idademinima)
{
    Console.WriteLine("Você pode fazer parte do curso.");
}
else
{
    Console.WriteLine("infelizmente você não pode participar do curso!");
}

//ternário 
int idadedacris = 20;
int idadearthur = 30;
Console.WriteLine(idadedacris > idadearthur ? "cris" : "arthur");*/

//switch
/*int numerodomes = 12;
string mes = "";
switch (numerodomes)
{
    case 1:
        mes = "janeiro";
        break;
    case 2:
        mes = "fevereiro";
        break;
    case 3:
        mes = "março";
        break;
    case 4:
        mes = "abril";
        break;
    case 5:
        mes = "maio";
        break;
    case 6:
        mes = "junho";
        break;
    case 7:
        mes = "julho";
        break;
    case 8:
        mes = "agosto";
        break;
    case 9:
        mes = "setembro";
        break;
    case 10:
        mes = "outubro";
        break;
    case 11:
        mes = "novembro";
        break;
    case 12:
        mes = "dezembro";
        break;
    default:
        mes = "mês inválido";
        break;
}
Console.WriteLine(mes);*/

/*Estrutura de controle 2
float valorA = 20;
float valorB = 10;
string operacao = "*";

switch (operacao)
{
    case "+":
        Console.WriteLine(valorA + valorB);
        break;
    case "-":
        Console.WriteLine(valorA - valorB);
        break;
    case "*":
        Console.WriteLine(valorA * valorB);
        break;
    case "/":
        Console.WriteLine(valorA / valorB);
        break;
    default:
        Console.WriteLine("operação inválida!");
        break;
}*/

//ESTRUTURA DE REPETIÇÃO
//WHILE
/*int inicializacao = 0;
while(inicializacao >= 3)
{
    Console.WriteLine("instrução do laço: " + inicializacao);
    inicializacao--;
}

//DO WHILE
do
{
    Console.WriteLine("instrução do laço: " + inicializacao);
    inicializacao++;
}while (inicializacao <= 3);*/

/*for (int inicio = 10; inicio >= 0; inicio--)
{
    Console.WriteLine("inicio: " + inicio);
}*/



// Arrays
/*int[] arrayInteiros = new int[4];
arrayInteiros[3] = 32;

// outra forma
int[] arrayComValores = new int[4] {23, 44, 55, 100};
arrayComValores[3] = 200;
Console.WriteLine(arrayComValores[1]);

int[] numeros = {10, 20, 30};
Console.WriteLine(numeros[1]);*/

string[] nomes = {"claudia", "cris", "arthur"};
Console.WriteLine(nomes[1]);

for (int itemdoarray = 0; itemdoarray < nomes.Length; itemdoarray++)
{
    Console.WriteLine(nomes[itemdoarray]);
}
