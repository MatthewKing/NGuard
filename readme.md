NGuard
=========

Introduction
------------
Lightweight guard / pre-condition / parameter validation library for .NET

Using a guard
-------------
````csharp
// Simple example:
void ExampleMethod(string input)
{
    Guard.Requires(input, nameof(input)).IsNotNull();
    
    // method body
}

// Chaining guards:
void ExampleMethod(string input)
{
    Guard.Requires(input, nameof(input)).IsNotNull().IsNotEmpty().IsNotWhiteSpace();
    
    // method body
}
````

Defining a custom guard
-----------------------
````csharp
// Example guard definition:
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

// Example guard usage:
void ExampleMethod(CustomType value)
{
    Guard.Requires(value, nameof(value)).SatisfiesCustomCondition();
    
    // method body
}
````

Copyright
---------
Copyright Matthew King 2012-2016.

License
-------
NGuard is licensed under the [MIT License](https://opensource.org/licenses/MIT). Refer to license.txt for more information.
