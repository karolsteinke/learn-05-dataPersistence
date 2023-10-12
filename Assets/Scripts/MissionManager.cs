using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionManager : MonoBehaviour
{
    public void GoToMain() {
        SceneManager.LoadScene(1);
    }

    public void GoToMenu() {
        SceneManager.LoadScene(0);
    }
}
