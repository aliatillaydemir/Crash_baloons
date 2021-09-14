using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonKontrolcu : MonoBehaviour
{
    public GameObject patlama;
    oyunKontrol oyunkontrolsc;

    void Start()
    {
        oyunkontrolsc = GameObject.Find("Script").GetComponent<oyunKontrol>();
    }

   void OnMouseDown()
    {
        GameObject go= Instantiate(patlama, transform.position, transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.267f);
        oyunkontrolsc.BalonEkle();
    }
}
