NGuard
=========

Introduction
------------
Lightweight guard / pre-condition / parameter validation framework for .NET

Using a guard
-------------
````csharp
// Simple example:
void ExampleMethod(string input)
{
    Guard.Requires(input, "input").IsNotNull();
    
    // method body
}

// Chaining guards:
void ExampleMethod(string input)
{
    Guard.Requires(input, "input").IsNotNull().IsNotEmpty().IsNotWhiteSpace();
    
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
            string message = paramName + " should satisfy custom condition.";
            throw new ArgumentException(message, paramName);
        }
    }
	
	return guard;
}

// Example guard usage:
void ExampleMethod(CustomType value)
{
    Guard.Requires(value, "value").SatisfiesCustomCondition();
    
    // method body
}
````

Copyright
---------
Copyright Matthew King 2012.

License
-------
NGuard is licensed under the [Boost Software License](http://www.boost.org/users/license.html). Refer to license.txt for more information.