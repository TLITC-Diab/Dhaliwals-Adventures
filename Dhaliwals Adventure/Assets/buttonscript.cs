using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        // input code that starts the game
        // input code that changes the scene
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

