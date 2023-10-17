using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public GameObject canvasGO3;
    PlayerController playerController;
    public GameObject Player;
    // Start is called before the first frame update
    void Awake()
    {
        playerController = Player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.moveSpeed = 0f;
            playerController.rotateSpeed = 0f; 
            canvasGO3.SetActive(true);
        }
    }
}
