using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Button_Hero : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject prefabCircle;

    [SerializeField]
    GameObject tower;


    private void Awake()
    {
        
        //Hero1_button.interactable = false;
    }
    public void playGame()
    {
        //Hero1_button.interactable = false;
        //Hero2_button.interactable = false;
        //Hero3_button.interactable = true;
        
        Debug.Log("click");
       
    }
    public void spawnBall(Vector3 position)
    {
        GameObject ball = Instantiate(prefabCircle);
        ball.transform.position = position;
        
    }
    public void hero1()
    {

        float x = 17.61f ;
        float y = tower.transform.position.y ;
        float z = tower.transform.position.z ;
        Vector3 pos = new Vector3(x, y, z);
        spawnBall(pos);
        Debug.Log("new hero 1");
     
    }
    public void hero2()
    {
        float x = 17.61f;
        float y = tower.transform.position.y;
        float z = tower.transform.position.z;
        Vector3 pos = new Vector3(x, y,z);
        spawnBall(pos);
        Debug.Log("new hero 2");
     
    }
    public void hero3()
    {
        float x = 17.61f;
        float y = tower.transform.position.y;
        float z = tower.transform.position.z;
        Vector3 pos = new Vector3(x, y, z);
        spawnBall(pos);
        Debug.Log("new hero3");
       
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
