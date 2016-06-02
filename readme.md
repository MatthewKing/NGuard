NGuard
======

Introduction
------------

Lightweight guard / pre-condition / parameter validation library for .NET

Installation
------------

`PM> Install-Package NGuard`

Using NGuard
------------

You can use a guard to ensure your method parameters match certain preconditions:

```csharp
void ExampleMethod(string input)
{
    Guard.Requires(input, nameof(input)).IsNotNull();
    
    // method body
}
```

Multiple guards can be chained together:

```csharp
void ExampleMethod(string input)
{
    Guard.Requires(input, nameof(input)).IsNotNull().IsNotEmpty().IsNotWhiteSpace();
    
    // method body
}
```

Defining a custom guard
-----------------------

Custom guards are easy to write. Just create a new extension method:

```csharp
static Guard<CustomType> SatisfiesCustomCondition(this Guard<CustomType> guard)
{
    if (guard.Value != null)
    {
        bool valid = /* code to test custom condition */
        if (!valid)
        {
            string paramName = guard.ParameterName;
            string message = $"{paramName} should satisfy custom condition.";
            throw new ArgumentException(message, paramName);
        }
    }
	
	return guard;
}
```

Now you can use your custom guard:

```csharp
void ExampleMethod(CustomType value)
{
    Guard.Requires(value, nameof(value)).SatisfiesCustomCondition();
    
    // method body
}
```

Copyright
---------

Copyright Matthew King 2012-2016.

License
-------

NGuard is licensed under the [MIT License](https://opensource.org/licenses/MIT). Refer to license.txt for more information.
