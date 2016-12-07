using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorProject12_1
{
    //Memory Calculator inherits Calculator
    class MemoryCalculator : Calculator
    { 
        //Constructor of the memory Calculator  
        public MemoryCalculator(decimal firstValue, decimal secondValue) : base(firstValue, secondValue)
        {
             
        }
       
       
        //A method that returns the value store in calculator
        public static decimal MemoryStore (decimal value)
        {


            return value;
        }
        //A method that recall the value store in the calculator
       public static decimal MemoryRecall( decimal memoryStoreVariable )
        {
            return memoryStoreVariable;
        }
        // A method that adds the value to memory in the  memory calculator
        public static decimal MemoryAdd(decimal value)
        {

            return value;
            
        }
        //Method that clears the  the controls
        public static decimal MemoryClear(decimal value)
        {
            
            return value; 
        }
  


    }
}
