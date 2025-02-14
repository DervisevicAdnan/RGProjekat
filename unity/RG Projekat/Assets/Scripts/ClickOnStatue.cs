using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnStatue : MonoBehaviour
{
    public AudioSource audioSource;
    bool svira = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource.Stop();
        svira = false;
    }

    void OnMouseDown(){
        if(svira)
        {
            audioSource.Stop();
            svira = false;
        }
        else
        {
            audioSource.Play();
            svira = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
