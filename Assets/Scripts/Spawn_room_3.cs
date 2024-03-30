using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn_room_3 : MonoBehaviour
{
    [SerializeField] GameObject prefeb_room_3_Object;
    [SerializeField] Transform z_start, z_end;
    // Start is called before the first frame update
    void Start()
    {
        object_spawn();
        z_start.GetComponent<Transform>();
        z_end.GetComponent<Transform>();
    }
    void object_spawn()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 random_position = Get_Random_Position();
            Instantiate(prefeb_room_3_Object, random_position, Quaternion.identity);
        }
    }

    Vector3 Get_Random_Position()
    {
        float x = Random.Range(-90f / 2f, 90f / 2f);
        float z = Random.Range(z_start.position.z / 2f, z_end.position.z / 2f);
        return new Vector3(x, 1.1f, z);
    }
}
