using System;
using System.Collections.Generic;
using System.Text;

namespace Ignat_Cristian_Aplicatie
{
    class Food
    {
        private FoodType mFood;
        public FoodType Meal
        {
            get
            {
                return mFood;
            }
            set
            {
                mFood = value;
            }
        }

        private float mPrice;
        public float Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public Food(FoodType aFood)
        {
            mFood = aFood;
        }
    }

    public enum FoodType {

        Radauteana,
        Alagrec,
        Ciorbalegume,
        Ciorbadeburta,
        SalataLight,
        Piuree,
        Pastrav,
        Carbonara,
        SalataOrientala,
        Lavacake,
        Clatite,
        Papanasi,
        Mousse
    }
}