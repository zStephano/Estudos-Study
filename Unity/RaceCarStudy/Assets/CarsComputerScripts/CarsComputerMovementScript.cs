using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsComputerMovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, -0.15f, 0);
        if (transform.position.y <= -13.13f)
            Destroy(gameObject);
    }
}
