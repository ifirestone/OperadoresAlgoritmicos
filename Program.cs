// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

double resultado;
Boolean result;


matematicos(35, 55);
relacionales(5, 10);
logicos(45, 90);


void matematicos(int a, int b)
{
    //Operadores Matematicos
    Console.WriteLine("Operadores Matematicos");

    Console.WriteLine("Variable A: " + a);
    Console.WriteLine("Variable B: " + b);
    
    // Suma
    resultado = a + b;
    Console.WriteLine("Resultado a+b: " + resultado);

    // Resta
    resultado = a - b;
    Console.WriteLine("Resultado a-b: " + resultado);

    // Multiplicacion
    resultado = a * b;
    Console.WriteLine("Resultado a*b: " + resultado);

    // Division
    resultado = a / b;
    Console.WriteLine("Resultado a/b: " + resultado);

    // Modulo
    resultado = a % b;
    Console.WriteLine("Resultado a%b: " + resultado);
};

 void relacionales(int a, int b)
{
    //Operadores Relacionales
    Console.WriteLine("Operadores Relacionales");

    Console.WriteLine("Variable A: " + a);
    Console.WriteLine("Variable B: " + b);

    result = a > b;
    Console.WriteLine("Resultado a > b: " + result);

    result = a < b;
    Console.WriteLine("Resultado a < b: " + result);

    result = a >= b;
    Console.WriteLine("Resultado a >= b: " + result);

    result = a <= b;
    Console.WriteLine("Resultado a <= b: " + result);

    result = a == b;
    Console.WriteLine("Resultado a == b: " + result);

    result = a != b;
    Console.WriteLine("Resultado a != b: " + result);
}


void logicos(int a, int b)
{
    //Operadores Logicos
    Console.WriteLine("Operadores Logicos");
    Console.WriteLine("Variable A: " + a);
    Console.WriteLine("Variable B: " + b);

    //Operadores Logicos &&
    Console.WriteLine("Operadores Logicos &&");
    result = (a > b) && (b < a);
    Console.WriteLine("Resultado (a > b) && (b < a): " + result);

    result = (a > b) && (a < b);
    Console.WriteLine("Resultado (a > b) && (a < b): " + result);

    result = (a < b) && (b < a);
    Console.WriteLine("Resultado (a < b) && (b < a): " + result);

    result = (a < b) && (b > a);
    Console.WriteLine("Resultado (a < b) && (b > a): " + result);

    //a=178 b=15
    //Operadores Logicos ||
    Console.WriteLine("Operadores Logicos ||");
    result = (a > b) || (b < a);
    Console.WriteLine("Resultado (a > b) || (b < a): " + result);

    result = (a > b) || (a < b);
    Console.WriteLine("Resultado (a > b) || (a < b): " + result);

    result = (a < b) || (b < a);
    Console.WriteLine("Resultado (a < b) || (b < a): " + result);

    result = (a < b) || (b > a);
    Console.WriteLine("Resultado (a < b) || (b > a): " + result);
}


