using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    BoxCollider2D boxCol;

    public float maxTime;

    [Serializable]
    public class Wave{
        public GameObject[] animals;

        public int maxAnimalCount;

        public float rate;

        public float time;

    }
    public Wave[] waves;

    float timer = 0;

    float spawnTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        boxCol = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        spawnTimer -= Time.deltaTime;

        for(int i = 0; i < waves.Length; i++){
            if (i == waves.Length -1){
                if((int)timer >= (int)waves[i].time && (int)timer<maxTime)
                {
                    if(spawnTimer <= 0)
                    {
                        Spawn(waves[i]);
                        spawnTimer = waves[i].rate;

                    }

                }
                else if((int)timer >= (int)waves[i].time && (int)timer<(int)waves[i+1].time)
                {
                    if(spawnTimer <= 0)
                    {
                        Spawn(waves[i]);
                        spawnTimer = waves[i].rate;

                    }

                }

            }
        }
        
    }

    void Spawn(Wave wave)
    {
        float yPos = UnityEngine.Random.Range(boxCol.bounds.min.y, boxCol.bounds.max.y);
        UnityEngine.Vector2 spawnPos = new UnityEngine.Vector2(transform.position.x, yPos);

        if(FindObjectsOfType<Animal>().Length < wave.maxAnimalCount)
        {
            int randomAnimal = UnityEngine.Random.Range(0, wave.animals.Length);
            Instantiate(wave.animals[randomAnimal], spawnPos, UnityEngine.Quaternion.identity);

        }

    }
}
