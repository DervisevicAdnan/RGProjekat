using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TacanOdgovor : MonoBehaviour
{
    public AudioSource audioTacno;
    public AudioSource audioNetacno;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnTacanKliknut(Button odgovor){
        odgovor.GetComponent<RawImage>().color = new Color32(144,255,144,255);
        audioTacno.Play();
    }
    public void OnTacanKliknut2(GameObject tipkaDalje){
        if(!tipkaDalje.activeSelf){
            tipkaDalje.SetActive(true);
        }
    }

    public void OnNetacanKliknut(Button odgovor){
        odgovor.GetComponent<RawImage>().color = new Color32(255,170,170,255);
        audioNetacno.Play();
    }
    
    public void OnDaljeKliknut(GameObject canvasTrenutni){
            canvasTrenutni.SetActive(false);
    }

    public void OnDaljeKliknut2(GameObject canvasNaredni){
            canvasNaredni.SetActive(true);
    }

    public void IzadjiIzAplikacije(){
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
