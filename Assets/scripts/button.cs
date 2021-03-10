using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{

    public Camera FirstCamera;
    public Camera SecondCamera;

    // Start is called before the first frame update
    void Start()
    {
        FirstCamera.enabled = true;
        SecondCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick() {
        enabled = FirstCamera.enabled;
        FirstCamera.enabled = SecondCamera.enabled;
        SecondCamera.enabled = enabled;
    }

}
