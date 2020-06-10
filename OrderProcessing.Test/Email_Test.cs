using NUnit.Framework;
using OrderProcesssing.BAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing.Test
{
    [TestFixture]
    public class Email_Test
    {
        private IMessage message;
        [SetUp]
        public void SetUp()
        {
            message = new Email();            
        }
        public void CanSendEmail()
        {
        }
    }
}
