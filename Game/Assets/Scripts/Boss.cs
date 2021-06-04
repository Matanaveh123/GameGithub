using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class Boss : MonoBehaviour
{
    [SerializeField] Transform upSpawn;
    [SerializeField] Transform leftSpawn;
    [SerializeField] Transform downSpawn;
    [SerializeField] Transform rightSpawn;

    [SerializeField] BossLaserShootPewPew laserToSpawn;

    [SerializeField] Light2D light2d;

    [SerializeField] int speed;


    float timeLeft;
    public float timeToWait;

    private void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            StartCoroutine("Shoot");
            timeLeft = timeToWait;
        }

        if(timeLeft > 0)
        {
            light2d.GetComponent<Light2D>().intensity = 0.8f;
        }
            
    }

    IEnumerator Shoot()
    {
        light2d.GetComponent<Light2D>().intensity = 2f;
        yield return new WaitForSeconds(0.1f);
        light2d.GetComponent<Light2D>().intensity = 0.8f;

        BossLaserShootPewPew upLaser = Instantiate(laserToSpawn, upSpawn.position, Quaternion.Euler(0, 0, 90));
        upLaser.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        upLaser.transform.parent = GameObject.Find("Up Spawn").transform;
        yield return new WaitForSeconds(0.01f);
        upLaser.transform.parent = null;
        Destroy(upLaser.gameObject, 3);

        BossLaserShootPewPew leftLaser = Instantiate(laserToSpawn, leftSpawn.position, Quaternion.Euler(0, 0, 0));
        leftLaser.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
        leftLaser.transform.parent = GameObject.Find("Left Spawn").transform;
        yield return new WaitForSeconds(0.01f);
        leftLaser.transform.parent = null;
        Destroy(leftLaser.gameObject, 3);

        BossLaserShootPewPew downLaser = Instantiate(laserToSpawn, downSpawn.position, Quaternion.Euler(0, 0, 90));
        downLaser.GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
        downLaser.transform.parent = GameObject.Find("Down Spawn").transform;
        yield return new WaitForSeconds(0.01f);
        downLaser.transform.parent = null;
        Destroy(downLaser.gameObject, 3);

        BossLaserShootPewPew rightLaser = Instantiate(laserToSpawn, rightSpawn.position, Quaternion.Euler(0, 0, 0));
        rightLaser.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        rightLaser.transform.parent = GameObject.Find("Right Spawn").transform;
        yield return new WaitForSeconds(0.01f);
        rightLaser.transform.parent = null;
        Destroy(rightLaser.gameObject, 3);
    }
}
