using Assets.Directions;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCar : DirectionsBase
{
    public Text timer;
    public Text record;

    void Start()
    {
        timer = GameObject.Find("Canvas").transform.Find("MyTime").GetComponent<Text>();
        record = GameObject.Find("Canvas").transform.Find("Record").GetComponent<Text>();

        timer.text += Time.deltaTime.ToString();
    }
    void Update()
    {
        ValidateKeyPressed();
        ControllersPositionY();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "car1")
        {
            chances -= 1;
            Thread.Sleep(1000);
            
            string currentSceneName = SceneManager.GetActiveScene().name;
            record.text = timer.text;
            SceneManager.LoadScene(currentSceneName);
            timer.text = null;

            if (chances <= 0)
            {
                Application.Quit();
            }
        }
    }

}
