using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAnimalFeed : MonoBehaviour
{

    private static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        score++;
        Debug.Log("Score = " + score);
    }
}
