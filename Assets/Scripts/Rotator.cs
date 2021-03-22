using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotator : MonoBehaviour, IPointerDownHandler
{
    public float speed;
    bool canRotate = true;

    public Material perfectMat;
    public Material defaultMat;


    private void Update()
    {
        if (canRotate)
        {
            transform.Rotate(10 * speed * Time.deltaTime, 0, 0);
            print(transform.rotation.x);
            if(transform.rotation.x > 0.95f || transform.rotation.x< -0.95f)
            {
                print("1");
                this.GetComponent<MeshRenderer>().material = perfectMat;
            }

            else
            {
                this.GetComponent<MeshRenderer>().material = defaultMat;
            }
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        print("2");
        canRotate = false;
    }
}
