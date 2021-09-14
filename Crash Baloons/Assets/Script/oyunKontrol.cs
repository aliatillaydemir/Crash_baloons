using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text zamanText, balonText;
    public GameObject patlama;
    public float zamanSayaci = 60;
    int patlayanBalon = 0;
  

    void Start()
    {
        balonText.text = "Balon : " + patlayanBalon;
        
    }

    void Update()
    {
        if (zamanSayaci > 0)
        {
            zamanSayaci -= Time.deltaTime;
            zamanText.text = "S�re : " + (int)zamanSayaci;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon_tag");//olu�turulan b�t�n balnlar bu taga sahip olurlar ve diziye atm�� olaca��z bunlar�. sonra dizide kalan balonlar� patlat�r�z.
            for(int i = 0; i < go.Length; i++)
            {
                Instantiate(patlama, go[i].transform.position, go[i].transform.rotation);
                Destroy(go[i]);
            }


        }
    }
    public void BalonEkle()
    {
        patlayanBalon+=1;
        balonText.text = "Balon : " + patlayanBalon;
    }

}
