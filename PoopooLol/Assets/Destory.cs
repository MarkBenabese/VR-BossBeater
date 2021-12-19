using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{

     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ice")
        {
            Destroy(collision.gameObject);
        }
    }

}
