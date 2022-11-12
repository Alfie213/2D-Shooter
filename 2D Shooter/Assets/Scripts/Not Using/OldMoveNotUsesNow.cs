using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldMoveNotUsesNow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    enum MyEnum
    {
        W = 1,
        A = -1,
        S = -1,
        D = 1
    }

    private void Go(KeyCode key)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.Translate(new Vector3(0, 1, 0));
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position += new Vector3(-1, 0, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position += new Vector3(0, -1, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position += new Vector3(1, 0, 0);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }
}
