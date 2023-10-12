using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerManager))]
[RequireComponent (typeof(MissionManager))]

public class Managers : MonoBehaviour
{
    public static PlayerManager Player {get; private set;}
    public static MissionManager Mission {get; private set;}

    void Awake() {
        DontDestroyOnLoad(gameObject);

        Player = GetComponent<PlayerManager>();
        Mission = GetComponent<MissionManager>();
    }
}
