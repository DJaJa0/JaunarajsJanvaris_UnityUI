using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParslegsana : MonoBehaviour
{
    
    public void UzOtruEkranu()
    {
        
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void UzSakumaEkranu()
    {
        
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void apturet()
    {
        Application.Quit();
    }
}
