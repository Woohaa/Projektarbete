using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projektarbete;
using System.Collections.Generic;

namespace Projektarbete_Test
{
	[TestClass]
	public class ProjektarbeteUnitTest
	{
		[TestMethod]
		public void Test_Coca_DividableBy3()
		{
			Manager manager = new Manager();

			bool expected = true;

			bool actual = manager.Coca();

			Assert.AreEqual(expected, actual); 
		}

		[TestMethod]
		public void Test_Cola_DividableBy5()
		{
			Manager manager = new Manager();

			bool expected = true;

			bool actual = manager.Cola();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_CocaCola_DividableBy3And5()
		{
			Manager manager = new Manager();

			bool expected = true;

			bool actual = manager.CocaCola();

			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void Test_ShowAllDividableNumbers()
		{
			Manager manager = new Manager();

			int expected = 59;

			int actual = manager.ShowAllDividableNumbers();

			Assert.AreEqual(expected, actual);

		}

	}
}
