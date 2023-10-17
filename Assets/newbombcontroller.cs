using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class newbombcontroller : MonoBehaviour
 
{
    public AudioClip collectSound;
    public bool collected = false;
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvasGO1;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        canvasGO1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && collected == (false))
        {
            collected = true;
            FatherController bombs = other.gameObject.GetComponent<FatherController>();
            FatherController.bombs++;
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            gameObject.GetComponent<Renderer>().enabled = true;
            canvas1.SetActive(false);
            canvas2.SetActive(true);
            canvasGO1.SetActive(true);
        }
    }
}
