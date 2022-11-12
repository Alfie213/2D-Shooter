using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedX, speedY, moveSpeed = 10, maxSpeed = 100;
    Vector3 tempVector;
    void Update()
    {
        /* ������ �� ���������, �.�. �� ��� �������� GetAxis (����� ������� GetAxisRow, ����� �������� ����� ����� �������)
         * tempVector.magnitude ����������, ����� ���������� �� ������ �� ������ ��������. ������� maxSpeed ������������ ��������� ���� */

        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");

        tempVector = gameObject.transform.position; // ������ ����� ������ transform.position?

        if (tempVector.magnitude < maxSpeed)
        {
            tempVector += new Vector3(speedX, speedY, 0) * (moveSpeed * Time.deltaTime);
        }

        transform.position = tempVector;
    }
}