using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionProgram
{
    public class UserInputProcessor:IDataProcessor
    {
        public string ProcessData(string input)
        {
            // Example operation: Convert input to uppercase
            return input.ToUpper();
        }
    }
}
