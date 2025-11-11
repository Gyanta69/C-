using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
//Task 2: 1.Inside the class NullOperations, create a method named PerformNullChecks()
namespace Lab4ConsoleApp
{
    internal class NullOperators
    {
        //2. Declare a string variable named username and assign null to it.
        public void PerformNullChecks()
        {
            string? username = null;
            //3. Use the Ternary Operator(? :) to check whether username is null:
            //If username is null, print: "Username is not available".Otherwise, print the value of username.

            string result = (username == null) ? "Username is not available" : username;
            Console.WriteLine(result);

            //4. Perform the same null checking using the Null-Coalescing Operator (??).
            string result2 = username ?? "Username is not available";
            Console.WriteLine(result2);

            //Use the Null - Coalescing Assignment Operator(??=) to assign a value to
            //username only if it is currently null.
            //After assignment, print the updated value of username.
            username ??= "DefaultUser";
            Console.WriteLine(username);





        }
    }
}
