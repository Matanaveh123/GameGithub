using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    [SerializeField] GameObject downBlackBar;
    [SerializeField] GameObject upBlackBar;
    [SerializeField] GameObject blackImage;

    [SerializeField] GameObject rocket;

    [SerializeField] GameObject player1;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject goldenPlayer;

    [SerializeField] GameObject text;
    [SerializeField] TMP_Text textToChange;

    [SerializeField] GameObject backInEarthText;

    [SerializeField] Sprite goldenPlayerSprite;

    [SerializeField] GameObject goldenBackground;
    [SerializeField] GameObject goldenRocket;
    [SerializeField] GameObject GoldenPlayerObject;

    [SerializeField] GameObject canvas;

    private void Start()
    {
        StartCoroutine("Intro");
    }

    IEnumerator Intro()
    {
        Time.timeScale = 0.75f;
        backInEarthText.gameObject.SetActive(true);
        blackImage.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        backInEarthText.gameObject.SetActive(false);
        downBlackBar.SetActive(true);
        upBlackBar.SetActive(true);
        rocket.SetActive(true);
        yield return new WaitForSeconds(10);
        player1.SetActive(true);
        player2.SetActive(true);
        text.SetActive(true);
        yield return new WaitForSeconds(4.25f);
        Destroy(player1);
        goldenPlayer.SetActive(true);
        textToChange.text = "what have i done?!";
        player2.GetComponent<Animator>().Play("PlayerGoesToCry");
        yield return new WaitForSeconds(2f);
        Time.timeScale = 0.3f;
        goldenBackground.SetActive(true);
        goldenRocket.SetActive(true);
        GoldenPlayerObject.SetActive(true);
        textToChange.text = "It's contagious! apparently Not All Glitter Is Gold..";
        yield return new WaitForSeconds(3);
        Time.timeScale = 0.75f;
        text.SetActive(false);
        canvas.SetActive(text);

    }

}
