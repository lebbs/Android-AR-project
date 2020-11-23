using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void btnOne()
    {
        Application.OpenURL("https://youtu.be/2q5rl7Hsd1Q?t=20");
    }
    public void btnTwo()
    {
        Application.OpenURL("https://1drv.ms/b/s!AqCNKHWXN2e1bLrximF5diYx4hU");
    }

    public void btnThree()
    {
        Application.OpenURL("https://1drv.ms/b/s!AqCNKHWXN2e1bmxuLp8FShyc-Ck");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
