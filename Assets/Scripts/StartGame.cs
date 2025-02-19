﻿using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{

    private Text start_text;
    private Text timer;
    private GameObject[] racks;
    private GameObject[] racku;

    private void Start()
    {
        start_text = GameObject.Find("Start Text").GetComponent<Text>();
        timer = GameObject.Find("Timer").GetComponent<Text>();
        timer.enabled = false;
        timer.GetComponent<Timer>().enabled = false;
        racks = GameObject.FindGameObjectsWithTag("Rack");
        racku = GameObject.FindGameObjectsWithTag("Rack_Utensil");
        foreach (GameObject e in racks)
        {
            e.SetActive(false);
            
        }
        foreach (GameObject e in racku)
        {
            e.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        print("Enter collider");
        //if (!other.gameObject.CompareTag("Before_Game"))
        //    return;

        GameObject[] before = GameObject.FindGameObjectsWithTag("Before_Game");
        GameObject[] after = GameObject.FindGameObjectsWithTag("During_Game");

        foreach(GameObject go in before)
        {
            go.SetActive(false);
        }
        foreach(GameObject go in after)
        {
            go.SetActive(true);
        }

        start_text.enabled = false;
        timer.enabled = true;
        timer.GetComponent<Timer>().enabled = true;

        foreach (GameObject e in racks)
        {
            e.SetActive(true);
        }
        foreach (GameObject e in racku)
        {
            e.SetActive(true);
        }

    }
}