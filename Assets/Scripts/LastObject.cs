using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastObject : MonoBehaviour
{
    public GameObject sphere;
    public bool canSwitchTarget=false;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Sphere"))
        {
            canSwitchTarget = true;
        }
    }
}
