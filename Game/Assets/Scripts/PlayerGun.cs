using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerGun : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    float timeLeft;
    public float timeToWait;

    public int coal;
    public TMP_Text coalText;

    [SerializeField] GameObject greenHeadLight; 

    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if (Input.GetButton("Fire1") && timeLeft < 0)
        {
            StartCoroutine("Shoot");
            timeLeft = timeToWait;
        }

    }

    IEnumerator Shoot()
    {
        greenHeadLight.SetActive(true);
        GameObject Bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet.transform.parent = GameObject.Find("Bullet Clones").transform;
        Destroy(Bullet, 2f);
        yield return new WaitForSeconds(0.1f);
        greenHeadLight.SetActive(false);
    }

    private void Awake()
    {
        coal = 0;
        coalText.text = "0";
    }
    public void addCoal()
    {
        coal++;
        coalText.text = coal.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<Target>())
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 16)
        {
            Destroy(collision);
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }

}
