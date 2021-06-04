using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
    [SerializeField] GameObject blackScreen;
    [SerializeField] GameObject controlsText;

    public void clicked()
    {
        StartCoroutine("ClickedYes");
    }

    IEnumerator ClickedYes()
    {
        controlsText.GetComponent<TextMeshProUGUI>().fontSize = 32;
        yield return new WaitForSeconds(0.1f);
        controlsText.GetComponent<TextMeshProUGUI>().fontSize = 36;
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Controls");

    }
}
