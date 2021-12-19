using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    // Time it takes in seconds to shrink from starting scale to target scale.
    public float ShrinkDuration = 100f;

    // The target scale
    public Vector3 TargetScale = Vector3.one * .5f;

    // The starting scale
    Vector3 startScale;

    // T is our interpolant for our linear interpolation.
    float t = 0;

    void OnEnable()
    {
        // initialize stuff in OnEnable
        startScale = transform.localScale;
        t = 0;
    }

    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "ice":
                ShrinkDuration = 5f;
                break;
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Smaller":
                // Divide deltaTime by the duration to stretch out the time it takes for t to go from 0 to 1.
                t += Time.deltaTime / ShrinkDuration;

                // Lerp wants the third parameter to go from 0 to 1 over time. 't' will do that for us.
                Vector3 newScale = Vector3.Lerp(startScale, TargetScale, t);
                transform.localScale = newScale;

                // We're done! We can disable this component to save resources.
                if (t > 1)
                {
                    enabled = false;
                }
                break;
        }
    }
}
