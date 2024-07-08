using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

namespace Assets.Directions
{
    public class DirectionsBase : MonoBehaviour
    {
        public GameObject[] tracks;
        public bool keyPressed = false;
        public float minY;
        public float maxY;
        public int chances = 3;

        public virtual void ValidateKeyPressed(KeyCode key = KeyCode.None)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
                keyPressed = true;

            else
            {
                if (keyPressed)
                {
                    var direction = Input.GetKey(KeyCode.RightArrow) ? KeyCode.RightArrow : KeyCode.LeftArrow;
                    var newPosition = TakePosition(transform.position, direction);
                    transform.position = newPosition;
                    keyPressed = false;
                }
            }
        }

        public void ControllersPositionY()
        {
            if (Input.GetKey("up"))
            {
                if (transform.position.y <= maxY)
                    transform.position += new Vector3(0, 0.1f, 0);
            }
            else if (Input.GetKey("down"))
            {
                if (transform.position.y >= minY)
                    transform.position += new Vector3(0, -0.1f, 0);
            }
        }

        public Vector3 TakePosition(Vector3 position, KeyCode direction)
        {
            int newPosition = 0;
            for (int i = 0; i < tracks.Length; i++)
            {
                if (position.x == tracks[i].transform.position.x)
                {
                    if (direction == KeyCode.RightArrow)
                        newPosition = i + 1;
                    else if (direction == KeyCode.LeftArrow)
                        newPosition = i - 1;
                    if (newPosition >= 0 && newPosition < tracks.Length)
                        return new Vector3(tracks[newPosition].transform.position.x, position.y, position.z);
                }
            }

            return position;
        }

    }
}
