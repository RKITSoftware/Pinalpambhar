using System;

namespace Properties_Demo
{
    class Accounts
    {
        string Name;
        float init_amount;
        static float interest;

        #region Properties for member Name
        public string CustomerName
        {
            set
            {           
                Name = value;
            }

            get
            {
                return Name;
            }
        }
        #endregion Properties for member Name

        #region Properties for member Initial Amount
        public float InitialAmount
        {
            set
            {
                if (value < 1000)
                {
                    Console.WriteLine("Initial amount cannot be less than 1000");
                    return;
                }
                init_amount = value;
            }

            get
            {
                return init_amount;
            }
        }
        #endregion Properties for member Initial Amount

        #region Properties for member InterestRate
        public static float InterestRate
        {
            get
            {
                return interest;
            }

            private set
            {
                interest = value;
            }
        }
        #endregion Properties for member InterestRate

        #region Constructor without parameter
        //simple constructor to assign Initial Amount 
        public Accounts()
        {
            this.InitialAmount = 10000;
        }
        #endregion Constructor without parameter

        #region Parameterized constructor
        /* Parameterized constructor
         * this will take amt as an input,
         * where amt is amount for the account
         * and set this amt value to class member IntialAmount */

        public Accounts(float amt)
        {
            this.InitialAmount = amt;
        }
        #endregion Parameterized constructor

        #region Static constructor
        // static constructor to access static member of the class
        static Accounts()
        {
            Accounts.InterestRate = 9.5f;
        }
        #endregion Static constructor
        static void Main(string[] args)
        {
            Accounts Objact = new Accounts();
            Objact.CustomerName = "Pinal Pambhar";

            Console.WriteLine("Name: {0}\nInitialAmount: {1}\nInterestRate: {2}",
                Objact.CustomerName,Objact.InitialAmount, Accounts.InterestRate);

            Accounts Objact1 = new Accounts(500);
            Console.WriteLine("InitialAmount: {0}",Objact1.InitialAmount);

            Accounts Objact2 = new Accounts(5000);
            Console.WriteLine("InitialAmount: {0}", Objact2.InitialAmount);
        }
    }
}
