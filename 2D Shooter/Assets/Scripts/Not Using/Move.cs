using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedX, speedY, moveSpeed = 10, maxSpeed = 100;
    Vector3 tempVector;
    void Update()
    {
        /*  нопки не указываем, т.к. за это отвечает GetAxis (можно сделать GetAxisRow, тогда движение будет менее плавным)
         * tempVector.magnitude ѕоказывает, какое рассто€ние мы прошли от начала движени€. ѕоэтому maxSpeed ограничивает дистнацию хода */

        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");

        tempVector = gameObject.transform.position; // почему можно просто transform.position?

        if (tempVector.magnitude < maxSpeed)
        {
            tempVector += new Vector3(speedX, speedY, 0) * (moveSpeed * Time.deltaTime);
        }

        transform.position = tempVector;
    }
}