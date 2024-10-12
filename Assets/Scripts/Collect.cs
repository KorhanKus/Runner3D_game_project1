using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collect : MonoBehaviour
{
    public PlayerController playerController;
    Vector3 PlayerStartPos;
    public GameObject RestartPanel;

    private void Start()
    {
        PlayerStartPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            playerController.runningSpeed = 0;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collision"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            transform.position = PlayerStartPos;
        }
    }



}
