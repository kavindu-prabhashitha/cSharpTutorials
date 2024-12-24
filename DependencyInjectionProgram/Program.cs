using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProgram
{
 /*
    In this solution, we define an interface IDataProcessor with a method ProcessData for processing data. 
    The UserInputProcessor class implements this interface and provides an example operation (converting input to uppercase). 
    The DataProcessingService class depends on IDataProcessor and uses it to perform operations. The DataProcessingService is designed to accept an IDataProcessor through constructor injection.

    In the Main method, we create instances of UserInputProcessor and DataProcessingService, and we use them to accept user input and perform operations. 
    This example does not use a full-fledged DI container but demonstrates the concept of Dependency Injection with a simple setup. In a real-world scenario, you might use a DI container like the one provided by .NET Core for more advanced and flexible dependency injection.
 */
    class MainProgram
    {
        static void Main()

        {

            // Setup dependency injection (using a simple example without a DI container)

            IDataProcessor userInputProcessor = new UserInputProcessor();

            DataProcessingService dataProcessingService = new DataProcessingService(userInputProcessor);

            // Accept user input

            Console.Write("Enter data for processing: ");

            string userInput = Console.ReadLine();

            // Use the data processing service to perform operations and display the result

            dataProcessingService.ProcessAndDisplay(userInput);

        }

    }
}


