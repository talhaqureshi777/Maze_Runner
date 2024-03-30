using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Over_Screen_Control : MonoBehaviour
{
    public void play_Again_Btn_Clicked()
    {
        SceneManager.LoadScene(1);
    }

    public void quit_Btn_Clicked()
    {
        Application.Quit(1);
    }
}
