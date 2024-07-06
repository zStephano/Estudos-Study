using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateCars : MonoBehaviour
{
    public GameObject[] cars;
    private float timer = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (var car in cars)
        {
            timer += Time.deltaTime;
            if (timer >= 1.5f)
            {
                timer = 0;

                Instantiate(
                    car.gameObject,
                    new Vector3(UnityEngine.Random.Range(-3.51f, 3.92f),
                    transform.position.y,
                    transform.position.z),
                    Quaternion.Euler(0, 0, -90f));
            }
        }
    }
}

