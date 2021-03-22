using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutCon : MonoBehaviour
{
    public bool isVisible=true;

    private void Update()
    {
        if(isVisible==false)
        {
            print("gameover");
        }
    }
    private void OnBecameInvisible()
    {
        isVisible = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("SphereEnd"))
        {
            enabled = false;
        }
    }

}
