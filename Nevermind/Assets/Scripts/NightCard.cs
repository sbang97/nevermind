using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightCard : MonoBehaviour
{
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(nightCardCo());
    }
    private IEnumerator nightCardCo()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(4f);
        text.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
