using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.UI;

public class trigger_test : MonoBehaviour
{
    public GameObject Anton;
    public List<GameObject> Now_time;
    public List<GameObject> Old_time;
    public Material Skybox_Now;
    public Material Skybox_Old;
    public GameObject image;
    private bool Time = true; // true = настоящее, false = прошлое

    private void OnTriggerEnter(Collider name)
    {      
        if(name.name == Anton.name && Time == true)
        {
            image.SetActive(true);
            for (int i = 0;  i < Now_time.Count; i++)
            {
                /*if (Now_time[i].tag == "Ground1")
                {
                    Now_time[i].GetComponent<Terrain>().enabled = false;
                }
                else*/ Now_time[i].SetActive(false);
            }
            for (int i = 0; i < Old_time.Count; i++)
            {
                /*if (Old_time[i].tag == "Ground2")
                {
                    Old_time[i].GetComponent<Terrain>().enabled = true;
                }
                else*/ Old_time[i].SetActive(true);
            }
            RenderSettings.skybox = Skybox_Old;           
        }  
        else if(name.name == Anton.name && Time == false)
        {
            image.SetActive(true);
            for (int i = 0; i < Now_time.Count; i++)
            {
                /*if (Now_time[i].tag == "Ground1")
                {
                    Now_time[i].GetComponent<Terrain>().enabled = true;
                }
                else*/Now_time[i].SetActive(true);
            }
            for (int i = 0; i < Old_time.Count; i++)
            {
                /*if (Old_time[i].tag == "Ground2")
                {
                    Old_time[i].GetComponent<Terrain>().enabled = false;
                }
                else*/ Old_time[i].SetActive(false);
            }
            RenderSettings.skybox = Skybox_Now;
        }
        if (Time == false)
        {
            Time = true;
        }
        else
        {
            Time = false;
        }
    }
}
