using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICallBack : MonoBehaviour
{
    public void OnClickHost() {
        MLAPI.NetworkingManager.Singleton.StartHost();
    }

    public void OnClickClient() {
        MLAPI.NetworkingManager.Singleton.StartClient();
    }
}
