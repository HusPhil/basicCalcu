using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAct3_Calc
{
    internal class Entry
    {
        private double _operandA { get; set; }
        private double _operandB { get; set; }
        private char _operation { get; set; }
        public bool calculated { get; set; }
        
        public bool operandA_Supplied { get; set; }
        public bool operandB_Supplied { get; set; }
        public bool operation_Supplied { get; set; }



        public double operandA
        {
            get { return _operandA; }
            set
            {
                _operandA = value;
            }
        }

        public double operandB
        {
            get { return _operandB; }
            set
            {
                _operandB = value;
            }
        }

        public char operation
        {
            get { return _operation; }
            set
            {
                _operation = value;
                operation_Supplied = true;
            }
        }

        public string EntryToString()
        {
            return $"OP_A: {this.operandA}\nOP: {this.operation}\nOP_B: {this.operandB}\nOP_A_S: {this.operandA_Supplied}\nOP_S: {this.operation_Supplied}\nCALC: {this.calculated}";
        }



    }
}
