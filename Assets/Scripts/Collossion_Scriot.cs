using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collossion_Scriot : MonoBehaviour
{
    [SerializeField] Text score_counter;
    [SerializeField] static int high_Score;
    public int score;



    void Start()
    {
          
    }
    void Update()
    {
        score_counter.text = score.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            score++;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(2);
        }
    }
   

}
