using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FatherController : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject buttonA;
    public GameObject buttonB;
    public GameObject bombs1;
    public GameObject bombs2;
    public GameObject bombs3;
    public GameObject bombs4;
    public GameObject bombs5;
    public GameObject bombs6;
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;
    public GameObject particle4;
    public GameObject particle5;
    public GameObject particle6;
    public GameObject newparticle;
    public GameObject newbombcanvas;
    public GameObject newbomb;
    public GameObject BombText;
    public TMP_Text newBombText;
    static public int bombs =0;
    public bool HasAccepted = false;
    public bool HasDeclined = false;
    
    

    // Start is called before the first frame update
    public void Start()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(false);
        canvas3.SetActive(false);
        newbombcanvas.SetActive(false);
        newparticle.SetActive(false);
        newbomb.SetActive(false);
    }

    private void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Player") && HasAccepted == (false) && HasDeclined == (false))
        { 
            canvas1.SetActive(true);
            
        }

        if (other.gameObject.tag == ("Player") && HasDeclined == (true))
        { 
            canvas2.SetActive(true);
            
        }

        if (other.gameObject.tag == ("Player") && HasAccepted == (true))
        { 
            canvas3.SetActive(true);
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvas1.SetActive(false);
            canvas2.SetActive(false);
            canvas3.SetActive(false);

        }
    }

    public void HasAcceptedb()
    {
        HasAccepted = true;
        canvas1.SetActive(false);
        canvas3.SetActive(true);
        bombs1.SetActive(false);
        bombs2.SetActive(false);
        bombs3.SetActive(false);
        bombs4.SetActive(false);
        bombs5.SetActive(false);
        bombs6.SetActive(false);
        particle1.SetActive(false);
        particle2.SetActive(false);
        particle3.SetActive(false);
        particle4.SetActive(false);
        particle5.SetActive(false);
        particle6.SetActive(false);
        BombText.SetActive(false);
        newbombcanvas.SetActive(true);
        newBombText.SetText("Bombs left: " + (1-bombs));
        newparticle.SetActive(true);
        newbomb.SetActive(true);
    }

    public void HasDeclinedb()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        HasDeclined = true;

    }
}
