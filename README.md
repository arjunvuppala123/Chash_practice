# C# Hello World Program Documentation

This documentation provides an overview and explanation of the C# code provided, which is a basic "Hello World" program with additional examples of variable declaration, constants, type conversion, and error handling.

## Table of Contents

1. [Introduction](#introduction)
2. [Hello World](#hello-world)
3. [Declaring Variables and Constants](#declaring-variables-and-constants)
4. [Formatting Strings](#formatting-strings)
5. [Type Conversion](#type-conversion)
6. [Try-Catch Block](#try-catch-block)

---

## Introduction <a name="introduction"></a>

The C# program provided is a console application that demonstrates various fundamental concepts of C#, including variable declaration, constants, type conversion, and error handling.

## Hello World <a name="hello-world"></a>

The program starts with the classic "Hello World!" message using the `Console.WriteLine` method. It also contains a commented out `Console.Beep()` statement that would produce a system beep sound if uncommented.

## Declaring Variables and Constants <a name="declaring-variables-and-constants"></a>

In this section, several variables and a constant are declared and printed:

- `number`: An integer variable initialized to `2`.
- `totalPrice`: A floating-point variable initialized to `20.91`.
- `firstName`: A string variable initialized to `"Arjun"`.
- `isWorking`: A boolean variable initialized to `true`.
- `num`: Another integer variable initialized to `6`.
- `Pi`: A constant floating-point variable initialized to `3.14`.

The values of these variables are printed to the console using `Console.WriteLine`.

## Formatting Strings <a name="formatting-strings"></a>

The `Console.WriteLine` method is used to print the minimum and maximum values of the `byte` data type using string formatting: `"{0} {1}"`.

## Type Conversion <a name="type-conversion"></a>

This section demonstrates both implicit and explicit type conversions:

- Implicit conversion: A `byte` variable `b` is assigned the value `1`, which is implicitly converted to an `int` variable `i`.
- Explicit conversion: A string `s` containing `"10"` is converted to an `int` using both `Convert.ToInt32` and `int.Parse` methods.

# C# Operators Documentation

This documentation provides an overview and explanation of the C# code that demonstrates various types of operators, including arithmetic, logical, conditional, and prefix/postfix operators.

## Table of Contents

1. [Introduction](#introduction)
2. [Arithmetic Operators](#arithmetic-operators)
3. [Logical Operators](#logical-operators)
4. [Conditional Operators](#conditional-operators)
5. [Prefix and Postfix Operators](#prefix-and-postfix-operators)

---

## Introduction <a name="introduction"></a>

The C# program provided demonstrates the use of various types of operators, including arithmetic, logical, conditional, and prefix/postfix operators. It showcases how these operators work and how to use them in C#.

## Arithmetic Operators <a name="arithmetic-operators"></a>

In this section, the program demonstrates arithmetic operators on two floating-point numbers `x` and `y`:

- Addition: `x + y`
- Division: `x / y`
- Multiplication: `x * y`
- Subtraction: `x - y`

The program calculates and prints the results of these operations.

## Logical Operators <a name="logical-operators"></a>

This section illustrates logical operators used to compare the values of `x` and `y`:

- Greater than: `x > y`
- Less than: `x < y`
- Equal To: `x == y`
- Not Equal to: `x != y`

The program evaluates these conditions and prints the results as `true` or `false`.

## Conditional Operators <a name="conditional-operators"></a>

Here, the program demonstrates conditional operators:

- AND operator (`&&`): `x > 0 && y > 0`
- OR operator (`||`): `x > 0 || y > 0`
- NOT operator (`!`): `!(x > 0 && y > 0)`

The program evaluates these conditional expressions and prints the results as `true` or `false`.

## Prefix and Postfix Operators <a name="prefix-and-postfix-operators"></a>

This section showcases the use of prefix and postfix operators on the variable `x`:

- Prefix Operator (`++x`): Increments `x` by 1 before using its current value.
- Postfix Operator (`x++`): Uses the current value of `x` and then increments it by 1.

The program prints the values of `x` before and after applying these operators to demonstrate the difference between them.

---

This C# program provides practical examples of various operators used in the language, including arithmetic, logical, conditional, and prefix/postfix operators. It serves as a useful reference for understanding how these operators work in C#.



