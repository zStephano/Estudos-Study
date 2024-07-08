using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    private bool hasInstantiate = false;

    private float speed = -0.1f;
    void Start()
    {
        
    }

    void Update()
    {
        // Instanciar transform.position com um novo Vector3 com valores padr�o
        transform.position += new Vector3(0, speed, 0);

        // Se a posi��o Y for inferior ou igual a -13.13f, destruir� o objeto -- desempenho + e abrir� possibilidades de rolagem de repeti��o
        if (transform.position.y <= -13.13f)
        {
            Destroy(gameObject);
        }

        // Caso contr�rio, ir� instanciar uma nova posi��o de objeto para o plano de fundo como GameObject, repetindo isso.
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
