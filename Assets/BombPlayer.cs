using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BombPlayer : MonoBehaviour
{
    public int bombs =0;
    public TMP_Text BombText;
    public GameObject getouttext;
    // Start is called before the first frame update
    void Start()
    {
        getouttext.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        BombText.SetText("Bombs left: " + (6-bombs));
        if (bombs == 6)
        {
            getouttext.SetActive(true);
        }
        
        
        
    }
}
