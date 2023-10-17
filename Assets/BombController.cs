using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BombController : MonoBehaviour
 
{
    public AudioClip collectSound;
    public bool collected = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
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
            BombPlayer player = other.gameObject.GetComponent<BombPlayer>();
            player.bombs++;
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
}