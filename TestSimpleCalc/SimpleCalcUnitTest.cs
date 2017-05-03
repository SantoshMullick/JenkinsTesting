using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSimpleCalc
{
    [TestClass]
    public class SimpleCalcUnitTest
    {
        public enum operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        Addition.Add Math_Add = new Addition.Add();
        Subtraction.Subtract Math_Sub = new Subtraction.Subtract();
        Multiplication.Multiply Math_Mul = new Multiplication.Multiply();
        Division.Divide Math_Div = new Division.Divide();

        [TestMethod]
        [DataSource("TestData/Items", "TestData.xml")]
        public void TestMethod1(operations MathOperation, int num1, int num2, int result)
        {
            switch (MathOperation)
            {
                case operations.Add:
                    Assert.AreEqual(result, Math_Add.iAdd(num1, num2));
                    break;
                case operations.Subtract:
                    Assert.AreEqual(result, Math_Sub.iSubtract(num1, num2));
                    break;
                case operations.Multiply:
                    Assert.AreEqual(result, Math_Mul.iMultiply(num1, num2));
                    break;
                case operations.Divide:
                    Assert.AreEqual(result, Math_Div.iDivide(num1, num2));
                    break;
            }
        }
    }
}
