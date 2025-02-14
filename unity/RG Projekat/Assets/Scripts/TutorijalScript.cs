using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TutorijalScript : MonoBehaviour
{
    private string _currentSceneName;
    public GameObject loadingCanvas;
    public string sceneNameToLoad = "SampleScene";
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
         _currentSceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UcitajPocetnuScenu(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Startna");
    }

    public void UcitajARScenu(){
        //UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        StartCoroutine(LoadSceneAsyncCoroutine());
    }

    IEnumerator LoadSceneAsyncCoroutine()
    {
        // 1. Učitaj novu scenu asinhrono
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneNameToLoad);
        asyncLoad.allowSceneActivation = false;


        while(!asyncLoad.isDone){
            //Debug.Log($"Loading progress: {asyncLoad.progress * 100}%");
            slider.value = asyncLoad.progress;
            if(asyncLoad.progress >= 0.9f){
                asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }

        /*
        while (asyncLoad.progress < 0.9f) // Čekaj dok ne dostigne 90%
        {
            Debug.Log($"Loading progress: {asyncLoad.progress * 100}%");
            yield return null;
        }

        Debug.Log("Ucitano"); //Dodaj Debug
         // 2.  Postavi novoučitanu scenu kao aktivnu scenu
         Scene newScene = SceneManager.GetSceneByName(sceneNameToLoad);
        Debug.Log("Nek se ispisuje: " + newScene.name); //Dodaj debug
        
        // 3. Dozvoli aktivaciju scene i sačekaj
        asyncLoad.allowSceneActivation = true;
        Debug.Log("Ucitano2"); //Dodaj Debug
        while(!asyncLoad.isDone){
            Debug.Log($"Loading progress: {asyncLoad.progress * 100}%");
           yield return null;
        }
        Debug.Log("Ucitano napokon"); //Dodaj Debug
         yield return new WaitForSeconds(0.1f);

        SceneManager.SetActiveScene(newScene);

        
        // 4. Ugasi prethodnu scenu asinhrono
        AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(_currentSceneName);

        while (!asyncUnload.isDone)
        {
            //Možeš postaviti loading da prati progress unloada
            Debug.Log($"Unloading progress: {asyncUnload.progress * 100}%");
            yield return null;
        }
        Debug.Log("Unloadano"); //Dodaj Debug

        // 5. Ugasi loading kanvas i spremi novu scenu kao _currentSceneName
        loadingCanvas.SetActive(false);
        _currentSceneName = sceneNameToLoad;*/
    }

    public void IskljuciCanvas(GameObject canvas){
        canvas.SetActive(false);
    }

    public void UkljuciCanvas(GameObject canvas){
        canvas.SetActive(true);
    }
}