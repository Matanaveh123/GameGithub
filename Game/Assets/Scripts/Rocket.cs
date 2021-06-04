using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Rocket : MonoBehaviour
{
    [SerializeField] Sprite RocketLevel1;
    [SerializeField] Sprite RocketLevel2;
    [SerializeField] Sprite RocketLevel3;
    [SerializeField] Sprite RocketLevel4;
    [SerializeField] Sprite RocketLevel5;

    [SerializeField] GameObject coalSpawner;
    [SerializeField] GameObject enemies;
    [SerializeField] GameObject player;



    private void Update()
    {

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        if(player.GetComponent<PlayerGun>())
        {
            if (FindObjectOfType<PlayerGun>().coal == 0) spriteRenderer.sprite = RocketLevel1;
            if (FindObjectOfType<PlayerGun>().coal == 1) spriteRenderer.sprite = RocketLevel2;
            if (FindObjectOfType<PlayerGun>().coal == 2) spriteRenderer.sprite = RocketLevel3;
            if (FindObjectOfType<PlayerGun>().coal == 3) spriteRenderer.sprite = RocketLevel4;
            if (FindObjectOfType<PlayerGun>().coal == 4) spriteRenderer.sprite = RocketLevel5;

            if (FindObjectOfType<PlayerGun>().coal == 5) NextLevel();
        }

    }

    void NextLevel()
    {
        coalSpawner.SetActive(false);
        enemies.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10 && FindObjectOfType<PlayerGun>().coal == 5)
        {
            player.SetActive(false);
            GetComponent<Animation>().Play("Up");
            StartCoroutine("End");
        }

    }

    IEnumerator End()
    {
        yield return new WaitForSeconds(7.5f);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.buildIndex + 1);
    }
}
