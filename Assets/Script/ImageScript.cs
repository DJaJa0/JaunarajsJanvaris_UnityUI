using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject WalterWhite;
    public GameObject JessePinkman;
    //public GameObject lady;
    //public GameObject car;
    public GameObject leftToggle;
    public GameObject rightToggle;
    public Sprite[] spriteArray;
    public GameObject imageHolder;
    public Slider sizeSlider;  // Changed type to Slider for clarity
    public Slider rotationSlider;  // Changed type to Slider for clarity

    private Image imageComponent;

    private void Start()
    {
        // Cache the image component for better performance
        imageComponent = imageHolder.GetComponent<Image>();

        // Check if components are assigned
        if (imageComponent == null)
        {
            Debug.LogError("Image component is not assigned!");
        }

        if (sizeSlider == null)
        {
            Debug.LogError("Size slider is not assigned!");
        }

        if (rotationSlider == null)
        {
            Debug.LogError("Rotation slider is not assigned!");
        }
    }

    public void changeImage(int index)
    {
        if (index < 0 || index >= spriteArray.Length)
        {
            Debug.LogError("Index out of bounds");
            return;
        }

        imageComponent.sprite = spriteArray[index];
    }

    public void changeSize()
    {
        if (sizeSlider != null)
        {
            float size = sizeSlider.value;
            imageHolder.transform.localScale = new Vector2(size, size);
        }
    }

    public void changeRotation()
    {
        if (rotationSlider != null)
        {
            float rotation = rotationSlider.value;
            imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation * 360);
        }
    }
}
