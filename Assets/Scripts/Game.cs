using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    public Transform startingObject;

    public GameObject startText;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            startingObject.transform.Rotate(new Vector3(5, 0, 0));
            startText.SetActive(false);
        }
    }
}
