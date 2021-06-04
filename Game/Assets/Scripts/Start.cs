using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Start : MonoBehaviour
{
    [SerializeField] GameObject blackScreen;
    [SerializeField] GameObject startText;

    public void clicked()
    {
        StartCoroutine("ClickedYes");
    }

    IEnumerator ClickedYes()
    {
        blackScreen.SetActive(true);
        startText.GetComponent<TextMeshProUGUI>().fontSize = 32;
        yield return new WaitForSeconds(0.1f);
        startText.GetComponent<TextMeshProUGUI>().fontSize = 36;
        yield return new WaitForSeconds(4.5f);
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.buildIndex + 1);
    }

}
