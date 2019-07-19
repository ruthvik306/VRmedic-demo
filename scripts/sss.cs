using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sss : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textfield;

    void Start()
    {
        textfield.text = "Hi Hisashi";
    }
    public void BtnFunc()
    {
        StartCoroutine(DisplayText());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DisplayText()
    {
        yield return new WaitForSeconds(3f);
        textfield.text = "hi ackerman";
    }
}
