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

## Try-Catch Block <a name="try-catch-block"></a>

The program includes a `try` block to demonstrate error handling. It attempts to convert the string `"1234"` to a `byte` using `Convert.ToByte`. Since this conversion is not
