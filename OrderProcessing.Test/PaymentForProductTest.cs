using NUnit.Framework;
using OrderProcesssing.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Test
{
	[TestFixture]
	public class CardPayment_test
	{
		private CardPayment cardPayment;
		private Product product;
		[SetUp]
		public void SetUp()
		{
			product = new PhysicalProduct();
			cardPayment = new CardPayment();
			cardPayment.IsHavingCommision = true;
		
		}
		[Test]
		public void isCardPaymentHasCommision()
		{
			Assert.IsTrue(cardPayment.IsHavingCommision);
		}
		[Test]
		public void CanCardPaymentPerformPayment()
		{
			var response = cardPayment.MakePayment(product);

			Assert.AreEqual("Payment is Succssfull", response);
		}

	}
}
