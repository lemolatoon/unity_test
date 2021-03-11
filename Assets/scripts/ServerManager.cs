using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Server");
        MLAPI.NetworkingManager.Singleton.StartServer();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
