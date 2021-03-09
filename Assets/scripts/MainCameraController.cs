using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera camera;
    private Vector3 INITIALPOS;
    void Start()
    {
        camera = GetComponent<Camera>();
        //相対座標
        INITIALPOS = camera.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift)) {
            camera.transform.localPosition += new Vector3(0,0.001f,-0.001f);
        }

        //keyを離したとき
        if(Input.GetKeyUp(KeyCode.LeftShift)) {
            camera.transform.localPosition = INITIALPOS;
        }
    }
}
