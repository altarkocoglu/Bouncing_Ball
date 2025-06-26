using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donusaltıgen : MonoBehaviour
{
    private float beklemeSuresi = 0.02f;
    void Update()
    {
        StartCoroutine(AltigenDonus());
    }

    IEnumerator AltigenDonus()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, 0));

        if (Input.GetMouseButtonDown(0) && mousePos.x > 0) //sağ
        {
            transform.Rotate(0, 0, -10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, -10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, -10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, -10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, -10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, -10);
        }
        else if (Input.GetMouseButtonDown(0) && mousePos.x < 0) //sol
        {
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
        }
    }

}
