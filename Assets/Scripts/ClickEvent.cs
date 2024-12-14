using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickEvent : MonoBehaviour
{
    static int easy = 1;
    static int medium = 0;
    static int hard = 0;
    private static string previousScene = "Menu"; 
    private static string previousScene2 = "Menu";

    void Start()
    {

        FindObjectOfType<ChangeButtonColor>().ChangeColor(easy, medium, hard);
    }

    void Update()
    {

        FindObjectOfType<ChangeButtonColor>().ChangeColor(easy, medium, hard);
    }

    public void playbttn()
    {
        if (easy == 1)
        {
            SceneManager.LoadScene("Easy");
        }
        else if (medium == 1)
        {
            SceneManager.LoadScene("medium");
        }
        else if (hard == 1)
        {
            SceneManager.LoadScene("Hard");
        }
    }

    public void Quitbttn()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void musicbttn()
    {
        previousScene2 = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Music");
    }

    public void difficultybttn()
    {
        previousScene = SceneManager.GetActiveScene().name; 
        SceneManager.LoadScene("diffculty");
    }

    public void Aboutbttn()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void menubttn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restartbttn()
    {
        if (easy == 1)
        {
            SceneManager.LoadScene("Easy");
        }
        else if (medium == 1)
        {
            SceneManager.LoadScene("medium");
        }
        else if (hard == 1)
        {
            SceneManager.LoadScene("hard");
        }
    }

    public void backbttn2()
    {
        if (previousScene2 == "Menu")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (previousScene2 == "over")
        {
            SceneManager.LoadScene("over");
        }
    }

    public void backbttn()
    {
        if (previousScene == "Menu")
        {
            SceneManager.LoadScene("Menu");
        }
        else if (previousScene == "over")
        {
            SceneManager.LoadScene("over");
        }
    }

    public void easybttn()
    {
        easy = 1;
        medium = 0;
        hard = 0;
        FindObjectOfType<ChangeButtonColor>().ChangeColor(easy, medium, hard);
    }

    public void mediumbttn()
    {
        easy = 0;
        medium = 1;
        hard = 0;
        FindObjectOfType<ChangeButtonColor>().ChangeColor(easy, medium, hard);
    }

    public void hardbttn()
    {
        easy = 0;
        medium = 0;
        hard = 1;
        FindObjectOfType<ChangeButtonColor>().ChangeColor(easy, medium, hard);
    }
}
