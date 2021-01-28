using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonscript : MonoBehaviour
{ 
    public bool startscreen = true;
    void Start()
    // Start is called before the first frame update
    {

    }

    public void Startbuttonpress()
    {
        startscreen = false;
        SceneManager.LoadScene("LVL 1");
    }

    public void OptionsButtonPress()
    {
        // options menu 
    }

    public void HelpButtonPress()
    {
        // help menu
    }
    // Update is called once per frame
    void Update()
    {

    }
}

