using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProgram
{
    public class DataProcessingService
    {
        private readonly IDataProcessor _dataProcessor;
        // Constructor injection

        public DataProcessingService(IDataProcessor dataProcessor)
        {
            _dataProcessor = dataProcessor;
        }

        public void ProcessAndDisplay(string input)
        {

            // Use the injected data processor to perform the operation
            string processedData = _dataProcessor.ProcessData(input);
            // Display the processed data to the user
            Console.WriteLine($"Processed Data: {processedData}");
        }

    }
}
