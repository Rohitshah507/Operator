using System;

public class NullOperations
{
    public void PerformNullChecks()
    {
        // Step 1: Declare and assign null
        string username = null;

        // Step 2: Ternary Operator (? :)
        string message = (username == null) ? "Username is not available" : username;
        Console.WriteLine("Ternary Operator Result: " + message);

        // Step 3: Null-Coalescing Operator (??)
        Console.WriteLine("Null-Coalescing Operator Result: " + (username ?? "Username is not available"));

        // Step 4: Null-Coalescing Assignment Operator (??=)
        username ??= "DefaultUser";  // assigns only if username is null
        Console.WriteLine("After Null-Coalescing Assignment: " + username);
    }
}
