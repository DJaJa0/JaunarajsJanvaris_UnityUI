using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Pievienojiet šo rindu

public class AtteluParadisana : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Text aprakstaLogs;
    public Sprite[] atteluMasivs;
    public string[] apraksts;
    

    public void izkritosais(int skaitlis)
    {
        // Pārbaudiet, vai mainigaisAttels nav null
        if (mainigaisAttels != null) 
        {
            Image imageComponent = mainigaisAttels.GetComponent<Image>();
            
            // Pārbaudiet, vai atteluMasivs ir ne tukšs un vai skaitlis ir derīgs
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
