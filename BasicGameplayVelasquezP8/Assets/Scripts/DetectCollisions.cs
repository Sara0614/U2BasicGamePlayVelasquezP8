using System.Collections;
using System.Collections.Generic;
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
        if (other.gameObject.tag == "Enemy")
        {
            HealthDecrementer();
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("GameOver!!");
        }
        

        void HealthDecrementer()
        {
            playerHealth = playerHealth - 1;
            Debug.Log("Lol");
            Debug.Log("Health = " + playerHealth);
        }
    }
}
