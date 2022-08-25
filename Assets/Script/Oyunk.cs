using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyunk : MonoBehaviour
{
    public bool oyunAktif = true;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinSayisiText, durum;
    public UnityEngine.UI.Button baslaButonu;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play(0);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void AltinArttir()
    {
        altinSayisi += 1;
        altinSayisiText.text = "Altin Sayisi : " + altinSayisi;
    }
    public void OyunBasla()
    {
        oyunAktif = true;
        baslaButonu.gameObject.SetActive(false);
    }

    public void YenidenBasla()
    {
        SceneManager.LoadScene("sahne");
    }

}
