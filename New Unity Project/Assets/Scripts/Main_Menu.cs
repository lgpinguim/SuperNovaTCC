using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public string primeiroNivel;
    Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        Color c = image.color;
        c.a = 0;
        image.color = c;

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
