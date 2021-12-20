using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.fixedDeltaTime, Space.Self);
    }

    public void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "iceball":
                speed = 0f;
                break;
        }
    }
}
