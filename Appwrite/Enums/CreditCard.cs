using System;

namespace Appwrite.Enums
{
    public class CreditCard : IEnum
    {
        public string Value { get; private set; }

        public CreditCard(string value)
        {
            Value = value;
        }

        public static CreditCard AmericanExpress => new CreditCard("amex");
        public static CreditCard Argencard => new CreditCard("argencard");
        public static CreditCard Cabal => new CreditCard("cabal");
        public static CreditCard Cencosud => new CreditCard("cencosud");
        public static CreditCard DinersClub => new CreditCard("diners");
        public static CreditCard Discover => new CreditCard("discover");
        public static CreditCard Elo => new CreditCard("elo");
        public static CreditCard Hipercard => new CreditCard("hipercard");
        public static CreditCard JCB => new CreditCard("jcb");
        public static CreditCard Mastercard => new CreditCard("mastercard");
        public static CreditCard Naranja => new CreditCard("naranja");
        public static CreditCard TarjetaShopping => new CreditCard("targeta-shopping");
        public static CreditCard UnionChinaPay => new CreditCard("union-china-pay");
        public static CreditCard Visa => new CreditCard("visa");
        public static CreditCard MIR => new CreditCard("mir");
        public static CreditCard Maestro => new CreditCard("maestro");
        public static CreditCard Rupay => new CreditCard("rupay");
    }
}
