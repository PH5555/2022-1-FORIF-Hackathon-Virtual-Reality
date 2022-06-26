using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private static int sceneNumber = 1;
    public static void NextSceneWithNum(){
        SceneManager.LoadScene(sceneNumber++); 
    }
}
