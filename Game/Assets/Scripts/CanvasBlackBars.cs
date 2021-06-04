using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasBlackBars : MonoBehaviour
{
    [SerializeField] GameObject upBar;
    [SerializeField] GameObject downBar;


    private void Start()
    {
        StartCoroutine("HandleAnimations");
    }

    IEnumerator HandleAnimations()
    {
        downBar.GetComponent<Animation>().Play("Bar2");
        upBar.GetComponent<Animation>().Play("Bar1");
        yield return new WaitForSeconds(7);
        downBar.GetComponent<Animation>().Play("Bar2Down");
        upBar.GetComponent<Animation>().Play("Bar1Down");
    }
}
