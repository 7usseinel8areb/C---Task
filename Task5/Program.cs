MathOperation operations;

operations = Operations.add;
Console.WriteLine($"Add {operations(1, 2)}");

operations = Operations.subtract;
Console.WriteLine($"Subtract {operations(1, 2)}");

operations = Operations.multiply;
Console.WriteLine($"Multiply {operations(1, 2)}");

operations = Operations.divide;
Console.WriteLine($"Divide {operations(1, 2)}");

operations = Operations.divide;
Console.WriteLine($"Divide {operations(1, 0)}");

public delegate int MathOperation(int a, int b);
