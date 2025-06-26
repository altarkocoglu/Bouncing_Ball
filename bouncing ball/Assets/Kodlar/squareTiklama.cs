using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class squareTiklama : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Sol fare tuþuna basýldýðýnda
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform == transform) // Eðer týklanan obje bu objeyse
                {
                    SceneManager.LoadScene("SampleScene"); // Yeni sahneye geçiþ
                }
            }
        }
    }
}