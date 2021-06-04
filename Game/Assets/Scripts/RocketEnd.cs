using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketEnd : MonoBehaviour
{
    [SerializeField] GameObject coalSpawner;
    [SerializeField] GameObject enemies;
    [SerializeField] GameObject player;

    [SerializeField] float timeToWait;

    private void Start()
    {
        StartCoroutine("NewLevel");

    }

    IEnumerator NewLevel()
    {
        player.SetActive(false);
        enemies.SetActive(false);
        coalSpawner.SetActive(false);
        yield return new WaitForSeconds(7.51f);
        player.transform.position = transform.position;
        player.SetActive(true);
        coalSpawner.SetActive(true);
        yield return new WaitForSeconds(timeToWait);
        enemies.SetActive(true);
    }
}
