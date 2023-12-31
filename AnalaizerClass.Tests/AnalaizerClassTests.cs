using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace AnalaizerClass.Tests
{
    [TestClass]
    public class AnalaizerClassTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("System.Data.SqlClient", "Server = HOME-PC;Integrated Security = True;Database = Test", "Tests", DataAccessMethod.Sequential)]
        [TestMethod]
        public void EstimateTest()
        {
            //Arrange
            string expression = (string)TestContext.DataRow["expression"];
            string expected = (string)TestContext.DataRow["expected"];
            AnalaizerClassLibrary.AnalaizerClass.expression = expression;

            //Act
            var result = AnalaizerClassLibrary.AnalaizerClass.Estimate();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}