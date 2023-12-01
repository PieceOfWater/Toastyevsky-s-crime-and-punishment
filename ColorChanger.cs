using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public float colorChangeDuration = 2f;

    void Start()
    {
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {

            GameObject[] redObjects = GameObject.FindGameObjectsWithTag("red");
            foreach (GameObject obj in redObjects)
            {             
                StartCoroutine(ChangeObjectColor(obj, Color.red));              
                this.GetComponent<Collider2D>().enabled = true;
            }

            EyesCheker eyes = FindObjectOfType<EyesCheker>();
            eyes.PlayRedAnim();
            yield return new WaitForSeconds(colorChangeDuration);
            foreach (GameObject obj in redObjects)
            {              
                StartCoroutine(ChangeObjectColor(obj, Color.white));
                this.GetComponent<Collider2D>().enabled = false;
            }

            yield return new WaitForSeconds(6f);

            GameObject[] blueObjects = GameObject.FindGameObjectsWithTag("blue");
            foreach (GameObject obj in blueObjects)
            {
                StartCoroutine(ChangeObjectColor(obj, Color.blue));
                this.GetComponent<Collider2D>().enabled = true;
            }
            eyes.PlayBlueAnim();
            yield return new WaitForSeconds(colorChangeDuration);
            foreach (GameObject obj in blueObjects)
            {
                StartCoroutine(ChangeObjectColor(obj, Color.white));
                this.GetComponent<Collider2D>().enabled = false;
            }

            yield return new WaitForSeconds(5f);
        }
    }

    IEnumerator ChangeObjectColor(GameObject obj, Color targetColor)
    {
        Renderer renderer = obj.GetComponent<Renderer>();
        Color startColor = renderer.material.color;

        float t = 0f;
        while (t < 1f)
        {
            t += Time.deltaTime / colorChangeDuration;
            renderer.material.color = Color.Lerp(startColor, targetColor, t);
            yield return null;
        }
    }
}