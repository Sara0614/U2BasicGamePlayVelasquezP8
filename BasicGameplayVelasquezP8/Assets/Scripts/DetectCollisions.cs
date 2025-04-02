using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int playerHealth = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        //CHeck if the other tag was the Player, if it was remove a life
        if (other.CompareTag("Player"))
        {
            GameManagerDependencyInfo.AddLives(-1);
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Enemy")
        {
            HealthDecrementer();
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Game Over!!");
        }
        

        void HealthDecrementer()
        {
            playerHealth = playerHealth - 1;
            Debug.Log("Lol");
            Debug.Log("Health = " + playerHealth);
        }
    }
}
