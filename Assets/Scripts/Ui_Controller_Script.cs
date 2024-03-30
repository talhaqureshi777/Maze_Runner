using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Ui_Controller_Script : MonoBehaviour
{
    [SerializeField] Text High_Score_Text;
    public static int high_score_count;
    Collossion_Scriot col;
    int current_bulid_Index;
    void Start()
    {
        current_bulid_Index = SceneManager.GetActiveScene().buildIndex;
        get_high_score();
        col = GameObject.FindObjectOfType<Collossion_Scriot>();
    }

    private void Update()
    {
        if(col.score > high_score_count)
        {
            high_score_count = col.score;
        }
        show_high_score();
        save_high_score();
    }

    void get_high_score()
    {
        PlayerPrefs.GetInt("HighScore");
    }
    void save_high_score()
    {
        PlayerPrefs.SetInt("HighScore", high_score_count);
    }

    void show_high_score()
    {
        High_Score_Text.text =  high_score_count.ToString();
    }
    public void start_Btn_Clicked()
    {
        SceneManager.LoadScene(current_bulid_Index + 1);   
    }

    public void quit_Btn_Clicked()
    {
        Application.Quit(1);
    }

    
}
