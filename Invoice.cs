using System;
using System.Collections.Generic;
using System.Text;


namespace PolyPayroll
{
    public class Invoice : iPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }
        private int quantity;
        private decimal pricePerItem;


        public Invoice(string partNumber, string partDescription, int quantity, decimal pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Quantity)} must be >= 0");
                }
                quantity = value;
            }
        }
        public decimal PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PricePerItem)} must be >= 0");
                }
                pricePerItem = value;
            }
        }
        public override string ToString() => $"Invoice:{RandomNumber(000001, 999999)}_{PartNumber}\nPart Description: {PartDescription}\n" + $"Quantity: {Quantity}\nPrice Per Item: {PricePerItem:C}";

        public decimal GetPaymentAmount() => Quantity * PricePerItem;

        private Random _random = new Random();

        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
            



        }
    }
}
