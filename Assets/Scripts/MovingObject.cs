using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovingObject : MonoBehaviour , IPointerDownHandler
{
    public Vector2 moveDir;
    public float speed;
    Vector3 leftTrans;
    Vector3 rightTrans;

    public bool isRight;
    public bool isLeft;

    bool canMove=true;

    bool inArea;

    public bool isInFloor;
    void Start()
    {
        rightTrans.x = transform.position.x+8;
        rightTrans.y = transform.position.y;
        rightTrans.z = transform.position.z;
        leftTrans.x = transform.position.x-8;
        leftTrans.y = transform.position.y;
        leftTrans.z = transform.position.z;
    }

    
    void Update()
    {
        if (canMove)
        {
            if (Vector3.Distance(transform.position, rightTrans) < 1f)
            {
                isRight = true;
                isLeft = false;
            }

            if (isRight)
            {
                transform.Translate(-moveDir * speed * Time.deltaTime);
            }

            if (Vector3.Distance(transform.position, leftTrans) < 1f)
            {
                isLeft = true;
                isRight = false;
            }

            if (isLeft)
            {
                transform.Translate(moveDir * speed * Time.deltaTime);
            }
        }
        else
        {
            if (!isInFloor)
            {
                if (inArea)
                {
                    enabled = false;

                }
                else
                {
                    //print("lose");
                    UIManager.instance.gameOverPanel.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
        
    }

    
    public void OnPointerDown(PointerEventData eventData)
    {
        canMove = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Block"))
        {
            canMove = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("OutCol"))
        {
            inArea = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("OutCol"))
        {
            inArea = false;
        }
    }

}
