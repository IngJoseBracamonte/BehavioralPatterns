using BehavioralPatterns.Interpreter.Math.Interfaces;
using BehavioralPatterns.Interpreter.Math.Models;

        // Crear la expresión 5 + 3 - 2
        IExpression expression = new Subtract(
            new Add(
                new Number(5),
                new Number(3)
            ),
            new Number(2)
        );

        int result = expression.Interpret();
        Console.WriteLine($"El resultado de la expresión 5 + 3 - 2 es: {result}");


//Explicación:
//Interfaz IExpression: Define el método Interpret que todas las expresiones deben implementar.

//Clases Number, Add, Subtract: Implementan la interfaz IExpression para manejar números y operaciones matemáticas.

//Uso en Program: Crea una expresión compuesta utilizando operadores y números, y la evalúa usando el método Interpret.