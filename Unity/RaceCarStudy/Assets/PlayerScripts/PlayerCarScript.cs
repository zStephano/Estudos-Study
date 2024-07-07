using UnityEngine;

public class TrocaDeFaixas : MonoBehaviour
{
    public GameObject[] tracks;
    private bool keyPressed = false;

    void Update()
    {
        ValidateKeyPressed();
        ControllersPositionY();
    }

    private void ValidateKeyPressed()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
            keyPressed = true;

        else
        {
            if (keyPressed)
            {
                var direction = Input.GetKey(KeyCode.RightArrow) ? "right" : "left";
                var newPosition = TakePosition(transform.position, direction);
                transform.position = newPosition;
                keyPressed = false;
            }
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

    private Vector3 TakePosition(Vector3 position, string direction)
    {
        int newPosition = 0;
        for (int i = 0; i < tracks.Length; i++)
        {
            if (position.x == tracks[i].transform.position.x)
            {
                if (direction == "right")
                    newPosition = i + 1;
                else if (direction == "left")
                    newPosition = i - 1;
                if (newPosition >= 0 && newPosition < tracks.Length)
                    return new Vector3(tracks[newPosition].transform.position.x, position.y, position.z);
            }
        }

        return position;
    }
}
