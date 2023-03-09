using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_data : MonoBehaviour

{
    [SerializeField]
    public int damage;
    [SerializeField]
    public int health;
    [SerializeField]
    public float speed;
    [SerializeField]
    public float goldGiven;
    [SerializeField]
    public float timeAttack;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy3" || collision.gameObject.tag == "Enemy2" || collision.gameObject.tag == "boss")
        {
            Debug.Log("hit");
        }
    }
}
