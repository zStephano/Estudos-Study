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
        // Instanciar transform.position com um novo Vector3 com valores padrão
        transform.position += new Vector3(0, speed, 0);

        // Se a posição Y for inferior ou igual a -13.13f, destruirá o objeto -- desempenho + e abrirá possibilidades de rolagem de repetição
        if (transform.position.y <= -13.13f)
        {
            Destroy(gameObject);
        }

        // Caso contrário, irá instanciar uma nova posição de objeto para o plano de fundo como GameObject, repetindo isso.
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
