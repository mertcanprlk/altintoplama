using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuK : MonoBehaviour
{
    public AudioClip altin, dusme;
    public Oyunk Oyunk;
    private float hiz = 10;
    public UnityEngine.UI.Button btn;
    public UnityEngine.UI.Text zaman, durum;
    float zamanSayaci = 30;
    bool oyunDevam = true; 
    bool bölümTamam = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Oyunk.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;

            transform.Translate(x, 0f, y);
        }
        if (oyunDevam && !bölümTamam)
        {
            zamanSayaci -= Time.deltaTime; //zamansayaci = zamansayaci-time.deltatime
            zaman.text = "Kalan Saniye : " + (int)zamanSayaci;

        }
        else if (!bölümTamam)
        {
            durum.text = "Bölüm Tamamlanamadı";
            btn.gameObject.SetActive(true);
        }
        if (zamanSayaci < 0)
            oyunDevam = false;
    }
    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {
            Oyunk.AltinArttir();
            Destroy(c.gameObject);
            GetComponent<AudioSource>().PlayOneShot(altin, 1f);
        }
        else if (c.gameObject.tag.Equals("dusman"))
        {
            Oyunk.oyunAktif = false;
            GetComponent<AudioSource>().PlayOneShot(dusme, 1f);
        }
        string objIsmi = c.gameObject.name;
        if (objIsmi.Equals("Bitis"))
        {
            //print("Bölüm Tamamlandı");
            bölümTamam = true;
            durum.text = "Bölüm Tamamlandı.Tebrikler!";
            btn.gameObject.SetActive(true);

        } else if (objIsmi.Equals("Kup"))
        {
            bölümTamam = true;
            durum.text = "Bölüm Tamamlanamadı.Tekrar Deneyiniz!";
            btn.gameObject.SetActive(true);
        }
        else if (objIsmi.Equals("Yer"))
        {
            bölümTamam = true;
            durum.text = "Bölüm Tamamlanamadı.Tekrar Deneyiniz!";
            btn.gameObject.SetActive(true);
        }
        else if (objIsmi.Equals("Kure"))
        {
            bölümTamam = true;
            durum.text = "Bölüm Tamamlanamadı.Tekrar Deneyiniz!";
            btn.gameObject.SetActive(true);
        }
    }
}
 

