using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles: MonoBehaviour
{
    bool canDesactivate;


    private void Start()
    {
        canDesactivate = true;
    }

    void Update()
    {
        if (canDesactivate)
            StartCoroutine(wait()); 
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
        canDesactivate = false;
    }
}
