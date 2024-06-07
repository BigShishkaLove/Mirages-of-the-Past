using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Black_Effect : MonoBehaviour
{
    private float fade_speed = 0.5f;
    private Image fade_image;
    private Color color;
    private bool faza2 = false;
    public GameObject image;
    void Start()
    {
        fade_image = GetComponent<Image>();
        color = fade_image.color;
    }

    void Update()
    {
        if (color.a < 1f && faza2 == false)
        {
            color.a += fade_speed * Time.deltaTime;
            fade_image.color = color;
            if (color.a >= 1f) faza2 = true;
        }
        else if (faza2 == true && (color.a >0))
        {
            color.a -= fade_speed * Time.deltaTime;
            fade_image.color = color;
            if (color.a <= 0)
            {
                faza2 = false;
                image.SetActive(false);
            }
        }  
    }
}
