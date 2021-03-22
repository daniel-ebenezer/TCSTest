using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rotator : MonoBehaviour, IPointerDownHandler
{
    public float speed;
    bool canRotate = true;

    private void Update()
    {
        if (canRotate)
        {
            transform.Rotate(10 * speed * Time.deltaTime, 0, 0);
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        canRotate = false;
    }
}
