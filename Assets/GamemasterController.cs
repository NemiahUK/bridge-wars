using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GamemasterController : MonoBehaviour
{
    public GameObject canvas;
    public bool gameStarted = false;
    public float startTime = 0.0f;
    GameObject[] stars;

    public void PlayerReady()
    {
        gameStarted = true;
        startTime = Time.time;
        canvas.SetActive(false);
        foreach (var star in stars)
        {
            star.SetActive(true);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        stars = GameObject.FindGameObjectsWithTag("Star");
        foreach (var star in stars)
        {
            star.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameStarted == false)
        {
            canvas.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvas.SetActive(false);
        }
    }
}
