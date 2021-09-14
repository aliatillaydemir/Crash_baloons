using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonOlustur : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi=1f;
    float zamanSayaci = 0f;
    oyunKontrol ok;


    void Start()
    {
        //ok = GameObject.Find("Script").GetComponent<oyunKontrol>();
        ok = this.gameObject.GetComponent<oyunKontrol>(); //ayný objeye baðlýlar onun için üstterki yerine bu yapýalbilir.
    }

  
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        int katsayi = (int)(ok.zamanSayaci / 10)-6;
        katsayi *= -1;

        if(zamanSayaci<0 && ok.zamanSayaci>0)
        {
            GameObject go = Instantiate(balon, new Vector3(Random.Range(-2.40f, 2.40f), -5.8f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D> ().AddForce(new Vector3(0, Random.Range(100f*katsayi,200f*katsayi), 0));
            zamanSayaci = balonOlusturmaSuresi;

        }
        
    }
}
