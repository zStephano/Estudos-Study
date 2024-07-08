using Assets.CarsAIScripts;
using Assets.Directions;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CarAIMovement : CarAI
{
    private float timer = 0;
    private bool isMovingForward = true;
    private float movementSpeed = 0.1f;
    void Update()
    {
        var direction = GetRandomDirection();

        timer += Time.deltaTime;

        if (timer > 0.5f)
        {
            timer = 0;
            // Lógica da IA para decidir a próxima ação (exemplo: escolha aleatoriamente entre as opções)
            ValidateKeyPressed(direction);
            isMovingForward = !isMovingForward;

        }

        // Movimento com base no estado
        if (isMovingForward)
        {
            if (transform.position.y <= maxY)
                transform.position += new Vector3(0, movementSpeed, 0); // Movimento para frente
        }
        else
        {
            if (transform.position.y >= minY)
                transform.position -= new Vector3(0, movementSpeed, 0); // Movimento para trás
        }
    }
}
