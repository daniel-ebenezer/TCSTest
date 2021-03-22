using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 7);
        }

        if (collision.gameObject.CompareTag("GameOver"))
        {
            UIManager.instance.endScreenPanel.SetActive(true);

        }

        if(collision.gameObject.CompareTag("Block"))
        {
            UIManager.instance.gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
