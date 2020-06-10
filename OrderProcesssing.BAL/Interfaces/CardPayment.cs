using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcesssing.BAL.Interfaces
{
    public class CardPayment : Payment
    {

        public CardPayment()
        {

        }
        public override string MakePayment(Product product)
        {
            IMembership membership;
            IMessage message;
            string emailMessage = string.Empty;
            if (product is Membership)
            {
                membership = new Membership();
                bool isMembership = membership.CheckUserHasMemberShip();
                if (isMembership)
                {
                    emailMessage = "Membership Upgraged";
                 
                    membership.UpgradeMemberShip();
                }
                else
                {
                    emailMessage = "Membership Activated";
                    membership.ActivateMemberShip();
                }
                message = new Email();
                message.SendMessage(emailMessage, "m@gmail.com");
            }
            Console.WriteLine(emailMessage);
            product.GenerateSlip();

            Console.WriteLine("Payment is successfull");
            return "Payment is Succssfull";
        }
    }
}
