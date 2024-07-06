using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private bool hasInstantiate = false;

    private float speed = -0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Instantiate transform.position with a new Vector3 with default values
        transform.position += new Vector3(0, speed, 0);

        // If the Y position goes under or equal -13.13f, will destroy the object -- performance + and open possibilities to scroll replay
        if (transform.position.y <= -13.13f)
        {
            Destroy(gameObject);
        }
        
        // Else if, will instantiate a new object position for background as GameObject, replaying that.
        else if (transform.position.y <= -1f)
        {
            if (hasInstantiate == false)
            {
                hasInstantiate = true;
                GameObject obj = Instantiate(
                    this.gameObject,
                    new Vector3(transform.position.x,
                    14.54f,
                    transform.position.z),
                    Quaternion.Euler(0, 0, 0));
            }
        }
    }
}
