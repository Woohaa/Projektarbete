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
		public void Test_ShowAllDividableNumbersValue()
		{
			Manager manager = new Manager();

			string expected = "1";
			string expected2 = "7";

			string actual = manager.ShowAllDividableNumbers(1);
			string actual2 = manager.ShowAllDividableNumbers(7);

			Assert.AreEqual(expected, actual);
			Assert.AreEqual(expected2, actual2);

		}

		[TestMethod]
		public void Test_ShowAllDividableNumbersBy3()
		{
			Manager manager = new Manager();

			string expected = "Coca";

			string actual = manager.ShowAllDividableNumbers(3);

			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Test_ShowAllDividableNumbersBy5()
		{
			Manager manager = new Manager();

			string expected = "Cola";
			
			string actual = manager.ShowAllDividableNumbers(5);
			
			Assert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Test_ShowAllDividableNumbersBy3_5()
		{
			Manager manager = new Manager();

			string expected = "CocaCola";

			string actual = manager.ShowAllDividableNumbers(15);

			Assert.AreEqual(expected, actual);

		}

	}
}
