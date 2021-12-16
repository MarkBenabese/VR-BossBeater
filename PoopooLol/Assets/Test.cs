using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float speed  = 2f;
    Vector3 temp;
    public void OnCollisionStay(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Bigger":
                temp = transform.localScale;
                temp.x += speed;
                temp.y += speed;
                temp.z += speed;
                transform.localScale = temp;
                break;
        }
    }
}
