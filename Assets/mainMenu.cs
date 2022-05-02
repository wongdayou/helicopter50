using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return"))
        {
            print("Loading scene");
            SceneManager.LoadScene("Main");
        }
        if (Input.GetKeyDown("escape"))
        {
            print("hello");
            Application.Quit();
        }
    }
}
