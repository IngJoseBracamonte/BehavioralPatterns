using BehavioralPatterns.Strategy.TaxCalculator.Models;



var taxCalculator = new TaxCalculator();

//Calcular impuesto en EE.UU.
 taxCalculator.SetTaxStrategy(new USTaxStrategy());
decimal usTax = taxCalculator.CalculateTax(100m);
Console.WriteLine($"Impuesto en EE.UU. para $100: {usTax}");


//Calcular impuesto en Europa
taxCalculator.SetTaxStrategy(new EuropeTaxStrategy());
decimal europeTax = taxCalculator.CalculateTax(100m);
Console.WriteLine($"Impuesto en Europa para €100: {europeTax}");


//Calcular impuesto en Japón taxCalculator.SetTaxStrategy(new JapanTaxStrategy());
decimal japanTax = taxCalculator.CalculateTax(100m);
Console.WriteLine($"Impuesto en Japón para ¥100: {japanTax}");

//Explicación:
//Interfaz ITaxStrategy: Define un método CalculateTax que cada estrategia debe implementar.

//Estrategias Concretas: Implementan la interfaz ITaxStrategy y encapsulan la lógica de cálculo del impuesto para diferentes regiones.

//Clase TaxCalculator: Mantiene una referencia a una estrategia de impuesto y delega el cálculo del impuesto a la estrategia actual.

//Uso en Program: Muestra cómo cambiar de estrategia en tiempo de ejecución para calcular impuestos en diferentes regiones.