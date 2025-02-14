 using UnityEngine;
 using UnityEngine.Video;
 
 public class VideoController : MonoBehaviour
 {
    public VideoPlayer videoPlayer;
     public GameObject quadObject; // Quad objekat sa VideoPlayer komponentom
 
     void Start()
     {
         string videoUrl = "file://" + Application.streamingAssetsPath + "/vino.mp4";
         videoPlayer.url = videoUrl; // Postavljamo URL putem skripte
         videoPlayer.Stop(); // zaustavi video na pocetku
         quadObject.SetActive(false);
     }
 
     void OnMouseDown() // kad se klikne na objekat sa skriptom
     {
        if (quadObject.activeSelf == false) //ako video nije aktivan
         {
              ShowVideo(); //prikazi video
         } else //ako je video aktivan
         {
             HideVideo(); //sakri video
         }
     }
     
     public void ShowVideo()
     {
         videoPlayer.Play();
         quadObject.SetActive(true);
     }
 
     public void HideVideo()
     {
         videoPlayer.Stop();
         quadObject.SetActive(false);
     }
 }