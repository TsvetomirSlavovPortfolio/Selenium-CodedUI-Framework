// <copyright file="TestIterations.cs" company="Infosys Ltd.">
//  Copyright (c) Infosys Ltd. All rights reserved.
// </copyright>
// <summary>TestIterations.cs class Reads test cases sheets and sets iterations.</summary>
namespace INF.Selenium.TestAutomation.TestIterations
{
    using System;
    using System.Reflection;
    using Configuration;
    using Entities;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Data.OleDb;
    /// <summary>
    /// Test iterations.
    /// </summary>
    [TestClass]
    public class TestIterations : BaseTestClass
    {
        /// <summary>
        /// Iterating the Test.
        /// </summary>
        [DeploymentItem(Constants.AppSetting.DeploymentItem)]
        [DataSource(Constants.AppSetting.Oledb, Constants.AppSetting.ConnectionString, Constants.AppSetting.TestIterationSheet, DataAccessMethod.Sequential)]
        [TestCategory(Constants.UnitTest)]
        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public void TestIterationsMethod()
        {
            try
            {
                TestCases.TestCases objTestCases = new TestCases.TestCases();
                objTestCases.Execute();
            }
            catch (Exception ex)
            {
                LogHelper.ErrorLog(ex, Constants.ClassName.TestIterationsClassName, MethodBase.GetCurrentMethod().Name);
                throw;
            }
        }
    }
}