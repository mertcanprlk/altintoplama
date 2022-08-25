using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamerak : MonoBehaviour
{
    public Oyunk oyunk;
    float hassasiyet = 5f;
    float yumusaklık = 2f;
    Vector2 gecisPos;
    Vector2 canPos;

    GameObject Oyuncu;

    // Start is called before the first frame update
    void Start()
    {
        Oyuncu = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunk.oyunAktif)
        {
            Vector2 farePos = new Vector2 (Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            farePos = Vector2.Scale (farePos, new Vector2(hassasiyet*yumusaklık, hassasiyet*yumusaklık));
            gecisPos.x = Mathf.Lerp (gecisPos.x, farePos.x, 1f / yumusaklık);
            gecisPos.y = Mathf.Lerp (gecisPos.y, farePos.y, 1f / yumusaklık);
            canPos += gecisPos;

            transform.localRotation = Quaternion.AngleAxis(-canPos.y, Vector3.right);
            Oyuncu.transform.localRotation = Quaternion.AngleAxis(canPos.x, Oyuncu.transform.up);
        }
    }
}
