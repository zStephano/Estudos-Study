using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assets.Directions;
using UnityEngine;

namespace Assets.CarsAIScripts
{
    public class CarAI : DirectionsBase
    {
        protected KeyCode GetRandomDirection()
        {
            var randomIndex = UnityEngine.Random.Range(0, 2);
            switch (randomIndex)
            {
                case 0:
                    return KeyCode.RightArrow;
                case 1:
                    return KeyCode.LeftArrow;
                default:
                    return KeyCode.None;
            }
        }

        public override void ValidateKeyPressed(KeyCode key)
        {
            if (key == KeyCode.RightArrow || key == KeyCode.LeftArrow)
            {
                keyPressed = true;
                var direction = key == KeyCode.RightArrow ? KeyCode.RightArrow : KeyCode.LeftArrow;
                var newPosition = TakePosition(transform.position, direction);
                transform.position = newPosition;
                keyPressed = false;
            }
        }
    }
}
