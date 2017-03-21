﻿using StringToExpression.Util;
using System;

namespace StringToExpression.Exceptions
{
    /// <summary>
    /// Exception when an bracket does not have the correct number of operands
    /// </summary>
    public class FunctionArgumentCountException : ParseException
    {
        /// <summary>
        /// StringSegment that contains the bracket that contains the incorrect number of operands
        /// </summary>
        public readonly StringSegment BracketStringSegment;

        /// <summary>
        /// Expected number of operands
        /// </summary>
        public readonly int ExpectedOperandCount;

        /// <summary>
        /// Actual number of operands
        /// </summary>
        public readonly int ActualOperandCount;

        public FunctionArgumentCountException(StringSegment bracketStringSegment, int expectedOperandCount, int actualOperandCount) 
            : base(bracketStringSegment, $"Bracket '{bracketStringSegment.Value}' contains {actualOperandCount} operand{(actualOperandCount > 1 ? "s" : "")} but was expecting {expectedOperandCount} operand{(expectedOperandCount > 1 ? "s" : "")}")
        {
            BracketStringSegment = bracketStringSegment;
            ExpectedOperandCount = expectedOperandCount;
            ActualOperandCount = actualOperandCount;
        }
    }
}
