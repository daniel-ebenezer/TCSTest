using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    public GameObject sphere;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Block"))
        {
            sphere.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 7);
        }
    }
}
