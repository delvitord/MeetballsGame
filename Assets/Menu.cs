using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainmenu;
    public GameObject backstory;
    public GameObject about;
    public GameObject tutorial;

    // Start is called before the first frame update
    void Start()
    {
        mainmenu.SetActive(true);
        backstory.SetActive(false);
        about.SetActive(false);
        tutorial.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play_button(string scenename) 
    {
        SceneManager.LoadScene(scenename);
    }

    public void Retry_button(string scenename) 
    {
        SceneManager.LoadScene(scenename);
    }

    public void Backstory()
    {
        mainmenu.SetActive(false); 
        backstory.SetActive(true);
        about.SetActive(false);
        tutorial.SetActive(false);
    }

    public void About()
    {
        mainmenu.SetActive(false); 
        backstory.SetActive(false);
        about.SetActive(true);
        tutorial.SetActive(false);
    }

    public void Tutorial()
    {
        mainmenu.SetActive(false); 
        backstory.SetActive(false);
        about.SetActive(false);
        tutorial.SetActive(true);
    }

    public void Backbutton(){
        mainmenu.SetActive(true); 
        backstory.SetActive(false);
        about.SetActive(false);
        tutorial.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }

}
