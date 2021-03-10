using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // Start is called before the first frame update
    //public Camera camera;
    private Vector3 INITIALPOS;
    public GameObject master;
    void Start()
    {
        master = GameObject.Find("GameMaster");
        //camera = this.GetComponent<Camera>();
        //相対座標
        INITIALPOS = transform.localPosition;
        master.GetComponent<GameMaster>().MainCamera = this.gameObject;
        Debug.Log("cameraをセット");
        Debug.Log(master.GetComponent<GameMaster>().MainCamera);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift)) {
            transform.localPosition += new Vector3(0,0.001f,-0.001f);
        }

        //keyを離したとき
        if(Input.GetKeyUp(KeyCode.LeftShift)) {
            transform.localPosition = INITIALPOS;
        }
    }
}
