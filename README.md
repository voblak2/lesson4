# lesson4

Methods
During this lesson, you will learn about methods and how they make tasks easier for developers. You will also learn the importance of the D.R.Y. principle, and learn how to group the code by name.

A method is a collection of statements that, together, perform a task. All C# programs have at least one class with a method named Main.

To use a method, you need to first define the method and then call the method to use it.

Defining Methods
When you define a method, you declare the elements of its structure. The syntax for defining a method in C# is as follows:

Access-Specifier Return-Type Method-Name(Parameter-List)
{
    Method Body
}
Access Specifier − Specifies the visibility of a method or variable to another class.
Return Type − Methods can return different types of values. The return type of the method is the data type of the value that is returned. When not returning a value, a method has a return type of void.
Method Name − The name of a method must be unique; no other method in the same class can have the same name. Method names are case-sensitive.
Parameter List − The parameters of a method are used for passing data to and from the method. They are enclosed within parentheses, and the parameter list refers to the type, order, and the number of parameters. Parameters are optional, and a method may have none.
Method Body − The body of the method is where the code that completes the required activity resides.
