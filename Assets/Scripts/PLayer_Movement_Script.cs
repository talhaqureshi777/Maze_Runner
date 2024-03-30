using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLayer_Movement_Script : MonoBehaviour
{
    [SerializeField] float force;
    // Start is called before the first frame update
    void Start()
    {
        force = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        player_Movement();
        if(transform.position.y < -200)
        {
            SceneManager.LoadScene(1);
        }
    }

    void player_Movement()
    {
        float move_horizontal = Input.GetAxis("Horizontal");
        float move_vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(move_horizontal, 0f, move_vertical);

        transform.Translate(movement * force * Time.deltaTime);
    }
}
