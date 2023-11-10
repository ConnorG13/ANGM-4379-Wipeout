using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGame : MonoBehaviour
{
    private GameObject playerObject;
    private GameObject playerCamera;
    private FollowPlayer cameraFollow;
    private float playerHeight;

    [SerializeField] private float delay = 1;
    private float timer;

    private void Start()
    {
        playerObject = this.transform.GetChild(0).gameObject;
        playerCamera = this.transform.GetChild(1).gameObject;
        cameraFollow = playerCamera.GetComponent<FollowPlayer>();
    }

    private void Update()
    {

        playerHeight = playerObject.transform.position.y;

        if (playerHeight <= -10)
        {
            if (cameraFollow.enabled == true)
            {
                cameraFollow.enabled = !cameraFollow.enabled;
            }

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
