using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamemasterW : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvasf;
    public GameObject canvas3645;
    FatherController fatherController;
    public GameObject Father;
    BombPlayer bombPlayer;
    public GameObject Player;
    public GameObject canvaskoniec;
    public GameObject canvasGO2;
    public GameObject canvaswelldone;
    public GameObject anotherbloodygoldtext;
    public GameObject currentgoldtext;
    public GameObject getouttext;

    // Start is called before the first frame update
    void Awake()
    {
        canvas.SetActive(false);
        canvas3645.SetActive(false);
        fatherController = Father.GetComponent<FatherController>();
        bombPlayer = Player.GetComponent<BombPlayer>();
        canvaskoniec.SetActive(false);
        canvasGO2.SetActive(false);
        canvaswelldone.SetActive(false);
        anotherbloodygoldtext.SetActive(false);
    }

    private void Update()
    {
       

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        { 
            canvas.SetActive(true);
            if (fatherController.HasAccepted == true)
            {
                canvas.SetActive(false);
                canvas3645.SetActive(true);
                canvaskoniec.SetActive(true);

            }
            if (bombPlayer.bombs == 6)
            {
                canvas.SetActive(false);
                canvaswelldone.SetActive(true);
                canvasGO2.SetActive(true);
                anotherbloodygoldtext.SetActive(true);
                currentgoldtext.SetActive(false);
                getouttext.SetActive(false);

            }
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canvas.SetActive(false);
            canvas3645.SetActive(false);
            canvaskoniec.SetActive(false);
            canvaswelldone.SetActive(false);
        }
    }
}
