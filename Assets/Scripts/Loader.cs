using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;
using System;
using UnityEngine.Experimental.UIElements;

public class Loader : MonoBehaviour
{
    public UnityEngine.UI.Button yourButton;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.UI.Button btn = yourButton.GetComponent<UnityEngine.UI.Button>();
        btn.onClick.AddListener(TaskOnClick);

        

    }

    public void TaskOnClick()
    {
        Application.OpenURL(@"https://1drv.ms/b/s!AqCNKHWXN2e1bWVj6sDpkHb1eY8");

      
    }

    


    // Update is called once per frame
    public void OnButton()
    {
        
    }
}
