using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timmy_animator_script : MonoBehaviour
{

    public Animator myAnim;
    public int setup = 0;
    private Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        scene = SceneManager.GetActiveScene();
        
    }

    // Update is called once per frame
    void Update()
    {
        dance();
    }


    public void dance()
    {
        if (scene.name == "Winscene" && setup == 0)
        {
            setup = 1;
            myAnim.Play("WinningPose");

        }

    }

}
