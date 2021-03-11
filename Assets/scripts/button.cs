using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{

    public GameObject FirstCamera;
    public GameObject SecondCamera;

    public GameObject master;

    // Start is called before the first frame update
    void Start()
    {
        //for linux build
        if(master.GetComponent<GameMaster>().MainCamera.activeSelf) {
            SecondCamera.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick() {
        if(!SecondCamera.activeSelf) {
            SecondCamera.SetActive(true);
            master.GetComponent<GameMaster>().MainCamera.SetActive(false);
        } else {
            master.GetComponent<GameMaster>().MainCamera.SetActive(true);
            SecondCamera.SetActive(false);
        }
    }

}
