using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoneticiAltıgen : MonoBehaviour
{
    public GameObject altigen, top, baslangicYazisi;
    public Transform baslangicPos;
    private bool basla = false;




    void Start()
    {
        altigen.GetComponent<donusaltıgen>().enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !basla)
        {
            top.transform.position = baslangicPos.position;
            altigen.GetComponent<donusaltıgen>().enabled = true;
            baslangicYazisi.SetActive(false);
            basla = true;

        }

    }
}
