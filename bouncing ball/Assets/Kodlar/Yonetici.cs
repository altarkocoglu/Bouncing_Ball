using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yonetici : MonoBehaviour
{
    public GameObject kare, top, baslangicYazisi;
    public Transform baslangicPos;
    private bool basla = false;




    void Start()
    {
        kare.GetComponent<donus>().enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !basla)
        {
            top.transform.position = baslangicPos.position;
            kare.GetComponent<donus>().enabled = true;
            baslangicYazisi.SetActive(false);
            basla = true;

        }

    }
}
