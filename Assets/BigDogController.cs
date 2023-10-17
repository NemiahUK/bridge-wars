using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BigDogController : MonoBehaviour
{
    public GameObject BigDog;
    public GameObject canvas1;
    public GameObject StartButton;
    public GameObject canvas2;
    public GameObject Q1A1;
    public GameObject Q1A2;
    public GameObject Q1A3;
    public GameObject Q1A4;
    public GameObject canvas3;
    public GameObject Q2A1;
    public GameObject Q2A2;
    public GameObject Q2A3;
    public GameObject Q2A4;
    public GameObject canvas4;
    public GameObject Q3A1;
    public GameObject Q3A2;
    public GameObject Q3A3;
    public GameObject Q3A4;
    public GameObject endcanvas1;
    public GameObject endcanvas2;
    public GameObject cool;
    public bool StartQ1b = false;
    public bool StartQ2b = false;
    public bool StartQ3b = false;
    public bool Startend1 = false;
    public bool Startend2 = false;
    public GameObject Father;

    // Start is called before the first frame update
    void Start()
    {
        
        canvas1.SetActive(false);
        canvas2.SetActive(false);
        canvas3.SetActive(false);
        canvas4.SetActive(false);
        endcanvas1.SetActive(false);
        endcanvas2.SetActive(false);
    }

    private void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player") && StartQ1b == (false) && StartQ2b == (false) && StartQ3b == (false) && Startend1 == (false) && Startend2 == (false))
        { 
            canvas1.SetActive(true);
            
        }

        if (other.gameObject.tag == ("Player") && StartQ1b == (true))
        { 
            canvas2.SetActive(true);
            
        }

        if (other.gameObject.tag == ("Player") && StartQ2b == (true))
        { 
            canvas3.SetActive(true);
            
        }

        if (other.gameObject.tag == ("Player") && StartQ3b == (true))
        { 
            canvas4.SetActive(true);
            
        }
        
        if (other.gameObject.tag == ("Player") && Startend1 == (true))
        { 
            endcanvas1.SetActive(true);
            
        }

        if (other.gameObject.tag == ("Player") && Startend2 == (true))
        { 
            endcanvas2.SetActive(true);
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            canvas1.SetActive(false);
            canvas2.SetActive(false);
            canvas3.SetActive(false);
            canvas4.SetActive(false);
            endcanvas1.SetActive(false);
            endcanvas2.SetActive(false);
        }
    }

    public void StartQ1()
    {
        StartQ1b = true;
        canvas2.SetActive(true);
        canvas1.SetActive(false);
        StartButton.SetActive(false);
    }

    public void WrongAnswer()
    {
        canvas2.SetActive(false);
        canvas3.SetActive(false);
        canvas4.SetActive(false);
        endcanvas1.SetActive(true);
        Startend1 = true;
        StartQ1b = false;
        StartQ2b = false;
        StartQ3b = false;
    }

    public void RightAnswer()
    {
        canvas2.SetActive(false);
        canvas3.SetActive(false);
        canvas4.SetActive(false);
        endcanvas2.SetActive(true);
        Startend2 = true;
        StartQ1b = false;
        StartQ2b = false;
        StartQ3b = false;
    }

    public void AfterRightAnswer()
    {
        endcanvas2.SetActive(false);
        BigDog.SetActive(false);
        Father.SetActive(false);
    }

    public void StartQ2()
    {
        StartQ1b = false;
        StartQ2b = true; 
        canvas3.SetActive(true);
        canvas2.SetActive(false);
        Q1A1.SetActive(false);
        Q1A2.SetActive(false);
        Q1A3.SetActive(false);
        Q1A4.SetActive(false);
    }

    public void StartQ3()
    {
        StartQ2b = false;
        StartQ3b = true; 
        canvas4.SetActive(true);
        canvas3.SetActive(false);
        Q2A1.SetActive(false);
        Q2A2.SetActive(false);
        Q2A3.SetActive(false);
        Q2A4.SetActive(false);
    }
}
