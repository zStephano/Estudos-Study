using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControllersPositionX();
        ControllersPositionY();
        ControllersPositionXandY();
    }

    private void ControllersPositionX()
    {
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0.1f, 0, 0);
        }
        else if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
    }
    private void ControllersPositionY()
    {
        if (Input.GetKey("up"))
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }
        else if (Input.GetKey("down"))
        {
            transform.position += new Vector3(0, -0.1f, 0);
        }
    }
    private void ControllersPositionXandY()
    {
        if (Input.GetKey("right") && Input.GetKey("up"))
        {
            transform.position += new Vector3();
        }
        else if (Input.GetKey("right") && Input.GetKey("down"))
        {
            transform.position += new Vector3();
        }
        else if (Input.GetKey("left") && Input.GetKey("up"))
        {
            transform.position += new Vector3();
        }
        else if (Input.GetKey("left") && Input.GetKey("down"))
        {
            transform.position += new Vector3();
        }
    }
}
