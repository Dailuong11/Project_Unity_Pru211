using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_move : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x + speed * Time.deltaTime;
        transform.position = new Vector3(posX, transform.position.y, -Camera.main.transform.position.z);
    }
}
