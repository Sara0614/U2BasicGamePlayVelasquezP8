using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private Vector3 spawnArea = new Vector3(35, 0, 20);
    private readonly float startDelay = 2;
    private bool isSpawning = true;


    private readonly float startInterval = 1.5f;

    Quaternion GetRandomRotation(int side)
    {
        Quaternion[] possibleRotations = new Quaternion[]{
            Quaternion.Euler(0, 90, 0),
            Quaternion.Euler(0, -90, 0),
            Quaternion.Euler(0, 180, 0),
        };

        return possibleRotations[side];
    }

    Vector3 GetRandomPerimeterPosition(int side)
    {
        float x = 0, y = 0, z = 0;

        switch (side)
        {
            case 0: // Left
                x = -spawnArea.x;
                y = 0;
                z = Random.Range(0, spawnArea.z / 2);
                break;
            case 1: // Right
                x = spawnArea.x;
                y = 0;
                z = Random.Range(0, spawnArea.z / 2);
                break;
            case 2: // Front
                x = Random.Range(-spawnArea.x / 2, spawnArea.x / 2);
                y = 0;
                z = spawnArea.z;
                break;
        }

        return new Vector3(x, y, z);
    }


    private void SpawnRandomAnimal()
    {
        if (isSpawning)
        {
            int side = Random.Range(0, 3); // Choose a random side: 0 = left, 1 = right, 2 = front,

            Vector3 randomPosition = GetRandomPerimeterPosition(side);
            Quaternion randomRotation = GetRandomRotation(side);

            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Instantiate(animalPrefabs[animalIndex], randomPosition, randomRotation);
        }

    }

    public void StopSpawning()
    {
        isSpawning = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomAnimal), startDelay, startInterval);
    }
}
