using UnityEngine;
using System.Collections;

namespace Test
{
    abstract class AllClass
    {

        private int pointDeVie;
        private int speed;

        public int PointDeVie
        {
            get
            {
                return pointDeVie;
            }

            set
            {
                pointDeVie = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }
    }
}
