using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public string playerName {get; private set;}
    
    public void OnSubmitName(string name) {
        playerName = name;
        //Debug.Log("playerName: " + playerName);
    }
}
