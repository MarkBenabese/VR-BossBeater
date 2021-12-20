using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    public float speed = 2f;
    Vector3 temp;

    public void OnTriggerStay(Collider collision)
    {
        switch (collision.gameObject.tag)
        {
            case "snow":
                temp = transform.localScale;
                temp.x += speed;
                temp.y += speed;
                temp.z += speed;
                transform.localScale = temp;
                break;
        }
    }
}
