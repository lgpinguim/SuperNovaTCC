using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public string primeiroNivel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {
        SceneManager.LoadScene(primeiroNivel);
    }

    public void optionsMenu()
    {

    }

    public void closeOptions()
    {

    }

    public void quitGame()
    {
        Application.Quit();
    }
}
