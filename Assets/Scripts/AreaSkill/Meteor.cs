using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;

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
        if (collision.gameObject.tag == "Ground" ||
            collision.gameObject.tag == "Enemy1" ||
            collision.gameObject.tag == "Enemy2" ||
            collision.gameObject.tag == "Enemy3" ||
            collision.gameObject.tag == "Boss")
        {
            Instantiate<GameObject>(prefabExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
