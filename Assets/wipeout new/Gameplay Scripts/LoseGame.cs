using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    private GameObject playerObject;
    private float playerHeight;

    [SerializeField] private float delay = 1;
    private float timer;

    private void Start()
    {
        playerObject = this.transform.GetChild(0).gameObject;
    }

    private void Update()
    {

        playerHeight = playerObject.transform.position.y;

        if (playerHeight <= -5)
        {

            timer += Time.deltaTime;
            if (timer > delay)
            {
                EndGame();
            }
            
        }
    }

    void EndGame()
    {
        SceneManager.LoadScene(3);
    }

}
