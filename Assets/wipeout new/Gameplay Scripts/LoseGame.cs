using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{

    public ParticleSystem particles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(particles, other.gameObject.transform.position, other.gameObject.transform.rotation);
            other.gameObject.SetActive(false);
            Invoke("MoveToLose", 1);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(particles, other.gameObject.transform.position, other.gameObject.transform.rotation);
            other.gameObject.SetActive(false);
            Invoke("MoveToLose", 1);
        }
    }

    private void MoveToLose()
    {
        SceneManager.LoadScene(3);
    }

}
