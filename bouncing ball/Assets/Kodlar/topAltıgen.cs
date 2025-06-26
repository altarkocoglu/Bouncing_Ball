using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class topAltıgen : MonoBehaviour
{
    private Rigidbody2D topRb;
    private SpriteRenderer topRenderer;
    public float ziplamaGucu;
    public Color color1, color2, color3, color4, color5, color6;
    public Text skorYazisi, rekorYazisi;
    private int skor, rekor;
    private bool oyunBasladi = false; // Oyunun başlama durumu

    void Start()
    {
        topRb = GetComponent<Rigidbody2D>();
        topRenderer = GetComponent<SpriteRenderer>();

        skor = 0;
        skorYazisi.text = "TAP TO START";

        if (PlayerPrefs.HasKey("rekor2"))
        {
            rekor = PlayerPrefs.GetInt("rekor2");
            rekorYazisi.text = "HIGH SCORE " + rekor.ToString();
        }
        else
        {
            rekor = 0;
        }

        if (PlayerPrefs.HasKey("sonSkor2"))
        {
            int sonSkor = PlayerPrefs.GetInt("sonSkor2");
            skorYazisi.text = "SCORE " + sonSkor.ToString();
        }
    }


    void Update()
    {
        // Oyunu başlatmak için ekrana tıklama kontrolü
        if (!oyunBasladi && Input.GetMouseButtonDown(0))
        {
            oyunBasladi = true;
            skor = 0; // Skor sıfırlanır
            skorYazisi.text = "SCORE " + skor.ToString(); // Skor metni güncellenir
        }
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (!oyunBasladi) return;

        if (temas.gameObject.tag == "Zemin")
        {
            topRb.AddForce(Vector2.up * ziplamaGucu, ForceMode2D.Impulse);
        }

        if (temas.gameObject.tag == "Kenar")
        {
            topRb.AddForce(Vector2.up * ziplamaGucu, ForceMode2D.Impulse);

            if (topRenderer.color == temas.gameObject.GetComponent<SpriteRenderer>().color)
            {
                skor += 1;
                skorYazisi.text = "SCORE " + skor.ToString();

                if (skor > rekor)
                {
                    rekor = skor;
                    rekorYazisi.text = "HIGH SCORE " + rekor.ToString();
                    PlayerPrefs.SetInt("rekor2", rekor);
                }
            }
            else
            {
                PlayerPrefs.SetInt("sonSkor2", skor);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D temast)
    {
        if (!oyunBasladi) return; // Oyun başlamadıysa tetikleyici işlemleri yapılmaz

        if (temast.gameObject.tag == "RenkDegistirici")
        {
            RenkDegistir();
        }
    }

    private void RenkDegistir()
    {
        int rastgele = Random.Range(1, 7);

        switch (rastgele)
        {
            case 1:
                topRenderer.color = color1;
                break;
            case 2:
                topRenderer.color = color2;
                break;
            case 3:
                topRenderer.color = color3;
                break;
            case 4:
                topRenderer.color = color4;
                break;
            case 5:
                topRenderer.color = color5;
                break;
            case 6:
                topRenderer.color = color6;
                break;
        }
    }
}
