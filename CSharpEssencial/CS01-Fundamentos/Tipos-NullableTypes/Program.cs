﻿// TIPOS DE DADOS: NULLABLE TYPES

int? a = null; // basta colocar o operador '?' após o tipo

// int b = a; // erro, variável do tipo 'int' não recebe valor do tipo 'int?'

int b = a ?? 0; // se 'a' for null, retorna 0

Console.WriteLine(b);

// Propriedades 'HasValue' e 'Value'
if (a.HasValue)
    Console.WriteLine(a.Value);
else
    Console.WriteLine("a não possui um valor (null)");

Console.ReadKey();
