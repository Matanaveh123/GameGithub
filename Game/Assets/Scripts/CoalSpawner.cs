using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalSpawner : MonoBehaviour
{

    [SerializeField] GameObject coal;

    float timeLeft;
    public float timeToWait;

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if(timeLeft <= 0)
        {
            GameObject Coal = Instantiate(coal, new Vector2(Random.Range(-8, 8), Random.Range(5.5f, 8)), transform.rotation);
            Coal.transform.parent = GameObject.Find("Coal Spawner").transform;
            timeLeft = timeToWait;
        }

    }

}
