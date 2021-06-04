using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coal : MonoBehaviour
{

    [SerializeField] Sprite goldCoalSprite;

    public bool pickable = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10 && pickable)
        {
            FindObjectOfType<PlayerGun>().addCoal();
            Destroy(gameObject);
        }

        StartCoroutine(EnemyTouchesCoalCheck(collision));

    }

    IEnumerator EnemyTouchesCoalCheck(Collision2D collision)
    {
        if (collision.gameObject.layer == 12)
        {
            GetComponent<SpriteRenderer>().sprite = goldCoalSprite;
            pickable = false;
            yield return new WaitForSeconds(5);
            Destroy(gameObject);

        }
    }
}
