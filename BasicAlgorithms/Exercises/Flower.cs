using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Flower
    {
        public enum Flowers
        {
            Rose,
            Sunflower,
            Lily,
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        private Flowers flower;
        public Flowers _Flower
        {
            get { return flower; }
            set { flower = value; }
        }
        private float price;
        public float Price
        {
            get { return price * quantity; }
            set { price = value; }
        }

        public Flower(int quantity, Flowers flower)
        {
            this.quantity = quantity;
            this.flower = flower;
            switch (flower)
            {
                case Flowers.Rose:
                    price = 12.4F;
                    break;
                case Flowers.Sunflower:
                    price = 10.3F;
                    break;
                case Flowers.Lily:
                    price = 7.2F;
                    break;
                default:
                    break;
            }
        }
    }
}
