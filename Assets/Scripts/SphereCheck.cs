using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCheck : MonoBehaviour
{

    public Path path;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("LastBlock"))
        {
            path.speed = 3.5f;
        }

        if (collision.gameObject.CompareTag("Block"))
        {
            path.speed = 4.5f;

        }
    }
}
