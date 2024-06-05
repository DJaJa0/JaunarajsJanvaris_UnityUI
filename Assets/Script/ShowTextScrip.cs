using System;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    public InputField nameInputField;
    public InputField yearInputField;
    public Text displayField;

    string[] greetings = { "Sveiki ", "Jauku dienu ", "Labrīt ", "Prieks Tevi redzēt " };
    
    public void DisplayText()
    {
        string name = nameInputField.text;
        string yearText = yearInputField.text;
        
        int year;
        if (int.TryParse(yearText, out year))
        {
            int randomIndex = UnityEngine.Random.Range(0, greetings.Length);
            int currentYear = DateTime.Now.Year;
            int age = currentYear - year;

            displayField.text = $"{greetings[randomIndex]}{name.ToLower()}! Varonis ir {age} gadus vecs!";
        }
        else
        {
            displayField.text = "Lūdzu, ievadiet pareizu dzimšanas gadu.";
        }
    }
}
