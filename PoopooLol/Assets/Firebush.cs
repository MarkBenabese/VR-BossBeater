using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firebush : MonoBehaviour
{
    public float speed = 2f;
    Vector3 temp;
    public Collider big;
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

    public void OnTriggerExit(Collider collision)
    {
        switch (collision.gameObject.tag)
        {
            case "snow":
                Destroy(big);
                break;
        }
    }
}
