using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonColor : MonoBehaviour
{
    public Button easyButton;  
    public Button mediumButton; 
    public Button hardButton;   

    public Color selectedColor = Color.green; 
    public Color defaultColor = Color.black;  


    public void ChangeColor(int easyi, int mediumi, int hardi)
    {
        string difficulty = "";

        if (easyi == 1 && mediumi == 0 && hardi == 0) 
        {
            difficulty = "Easy";
        }
        else if (easyi == 0 && mediumi == 1 && hardi == 0)
        {
            difficulty = "Medium";
        }
        else if (easyi == 0 && mediumi == 0 && hardi == 1)
        {
            difficulty = "Hard";
        }


        Image easyImage = easyButton.GetComponent<Image>();
        Image mediumImage = mediumButton.GetComponent<Image>();
        Image hardImage = hardButton.GetComponent<Image>();

        if (easyImage != null && mediumImage != null && hardImage != null)
        {

            switch (difficulty)
            {
                case "Easy":
                    easyImage.color = selectedColor;
                    mediumImage.color = defaultColor;
                    hardImage.color = defaultColor;
                    break;

                case "Medium":
                    easyImage.color = defaultColor;
                    mediumImage.color = selectedColor;
                    hardImage.color = defaultColor;
                    break;

                case "Hard":
                    easyImage.color = defaultColor;
                    mediumImage.color = defaultColor;
                    hardImage.color = selectedColor;
                    break;
            }
        }
    }
}
