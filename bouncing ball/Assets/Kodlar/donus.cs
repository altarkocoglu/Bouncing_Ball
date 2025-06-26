using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donus : MonoBehaviour
{
    private float beklemeSuresi = 0.02f;
    void Update()
    {
        StartCoroutine(KareDonus());
    }

    IEnumerator KareDonus()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, 0));

        if (Input.GetMouseButtonDown(0) && mousePos.x > 0) //sað
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
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
            yield return new WaitForSeconds(beklemeSuresi);
            transform.Rotate(0, 0, 10);
        }
    }

}
