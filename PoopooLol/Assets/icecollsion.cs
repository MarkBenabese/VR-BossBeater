using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icecollsion : MonoBehaviour
{
    Vector3 temp;

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ice":
                temp = transform.localScale;
                temp.x += temp.x /2;
                temp.y += temp.y /2;
                temp.z += temp.z /2;
                transform.localScale = temp;
                break;
        }
        
    }


}
