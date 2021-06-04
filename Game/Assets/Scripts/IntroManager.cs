using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    [SerializeField] GameObject downBlackBar;
    [SerializeField] GameObject upBlackBar;
    [SerializeField] GameObject blackImage;

    [SerializeField] GameObject rocket;

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;

    [SerializeField] GameObject text;
    [SerializeField] TMP_Text textToChange;

    [SerializeField] GameObject enemy;

    [SerializeField] Sprite goldenPlayerSprite;

    private void Start()
    {
        StartCoroutine("Intro");
    }

    IEnumerator Intro()
    {
        Time.timeScale = 0.75f;
        blackImage.SetActive(true);
        yield return new WaitForSeconds(5.49f);
        downBlackBar.SetActive(true);
        upBlackBar.SetActive(true);
        rocket.SetActive(true);
        yield return new WaitForSeconds(13);
        player1.SetActive(true);
        player2.SetActive(true);
        text.SetActive(true);
        yield return new WaitForSeconds(3);
        enemy.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        textToChange.text = "What? an alien?";
        yield return new WaitForSeconds(3f);
        textToChange.text = "George!";
        yield return new WaitForSeconds(0.6f);
        player2.GetComponent<SpriteRenderer>().sprite = goldenPlayerSprite;
        textToChange.text = "Nooooo!";
        yield return new WaitForSeconds(4f);
        textToChange.text = "I have to go back to earth! I just don't have enough coal to fly the ship!";
        yield return new WaitForSeconds(6);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.buildIndex + 1);

    }

}
