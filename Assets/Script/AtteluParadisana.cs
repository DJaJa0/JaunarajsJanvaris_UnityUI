using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class AtteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Text aprakstaLogs;
    public Sprite[] atteluMasivs;
    public string[] apraksts;
    

    public void izkritosais(int skaitlis)
    {
        
        if (mainigaisAttels != null) 
        {
            Image imageComponent = mainigaisAttels.GetComponent<Image>();
            
            
            if (imageComponent != null && atteluMasivs != null && skaitlis >= 0 && skaitlis < atteluMasivs.Length)
            {
                imageComponent.sprite = atteluMasivs[skaitlis];
                aprakstaLogs.text = apraksts[skaitlis];
            }
            else
            {
                Debug.LogWarning("Skaitlis ir ārpus atteluMasivs robežām vai atteluMasivs nav iestatīts pareizi.");
            }
        }
        else
        {
            Debug.LogError("mainigaisAttels nav iestatīts.");
        }
    }
}
