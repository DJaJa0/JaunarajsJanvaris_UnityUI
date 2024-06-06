using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateAndScaleSlider : MonoBehaviour
{
    public Slider rotationSlider;
    public Slider scaleSlider;

    private float angleSliderNumber;
    private float scaleSliderNumber;

    // Update is called once per frame
    void Update()
    {
        // Iegūst rotācijas leņķi no slīdņa vērtības
        angleSliderNumber = rotationSlider.value * 360f; // Piemēro pilnu 360 grādu rotāciju
        // Rotē objektu ap Z asi (2D plakne)
        this.transform.rotation = Quaternion.Euler(0, 0, angleSliderNumber);

        // Iegūst mērogošanas vērtību no slīdņa vērtības
        scaleSliderNumber = scaleSlider.value;
        // Mērogo objektu vienādi visos virzienos
        Vector3 scale = new Vector3(scaleSliderNumber, scaleSliderNumber, 1); // Z vērtība ir 1, jo tas ir 2D
        this.transform.localScale = scale;
    }
}
