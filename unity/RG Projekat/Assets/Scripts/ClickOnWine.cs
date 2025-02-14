using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ClickOnWine : MonoBehaviour
{
    public GameObject objekat; //javni parametar
    Ray ray; // deklaracija varijable Ray
    RaycastHit hit; // deklaracija varijable RaycastHit
    public VideoPlayer videoPlayer;
    private bool isVideoPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        //string videoPath = "Assets/YourVideo.mp4";
        //videoPlayer.url = videoPath;
    }
    // Update is called once per frame
    void Update()
    {
        // provjeri da li se desio dodir
        if(Input.GetMouseButtonDown(0))
        {
                // šalje se zraka od mjesta gdje je ekran dotaknut
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // provjera da li je neki objekat pogođen i upisuje ga u hit ako jeste
            if(Physics.Raycast(ray, out hit))
            {
                // pristupamo tag-u collidera na objektu koji je pogođen zrakom
                if(hit.collider.tag == "wine")
                {
                    if(objekat.activeSelf)
                    {
                        if (isVideoPlaying)
                        {
                            videoPlayer.Stop();
                            videoPlayer.time = 0;
                            objekat.SetActive(false);
                            isVideoPlaying = false;
                        }
                    }
                    else
                    {
                        objekat.SetActive(true);
                        videoPlayer.Play();
                        isVideoPlaying = true;
                    }
                }
            }
        }
    }
}
