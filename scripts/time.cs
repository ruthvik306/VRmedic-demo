using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class time : MonoBehaviour
{

    public float second;
    public TMP_Text hltext;
    //public TMP_Text icetext;
    //public GameObject firetext;
    public GameObject icemd;
    public GameObject firemd;
    //public float stime;
    //public TMP_Text textfield;
    public int i = 1;
    private void Start()
    {
        // stime = Time.time;
        //hltext.SetActive(false);
        //icetext.SetActive(false);
        //firetext.SetActive(false);
        //icemd.SetActive(false);
        //firemd.SetActive(false);
        //hltext.text= "Hi ! My name is DORA! I need you to help me protect my world by taking the Power Stones";
        CallChangeText();



    }

    void Update()
    {
        
        CallChangeText();
       
           


    }
    public void CallChangeText()
    {
        StartCoroutine(changeText01());
    }

    IEnumerator changeText01()
    {
        //StopAllCoroutines();
      //  hltext.text = "Take the ice stone to stop the snow storm !";
        hltext.text = "Hi ! My name is DORA! I need you to help me protect my world by taking the Power Stones";
        yield return new WaitForSeconds(9f);
        
        
        StartCoroutine(changeText02());
           
        
    }
    IEnumerator changeText02()
    {
        //StopAllCoroutines();
        //hltext.text = "PLease stop the fire, by taking this burning stone";
       
        icemodel();
        yield return new WaitForSeconds(10f);
        StartCoroutine(changeText03());
        
       
    }
    
    IEnumerator changeText03()
    {
        //StopAllCoroutines();
        
        //hltext.text = "Take the ice stone to stop the snow storm !";
        firemodel();
        yield return new WaitForSeconds(10f);
        firemd.SetActive(false);
        hltext.enabled = false;
        StartCoroutine(changeText04());

    }
    IEnumerator changeText04()
    {
        //StopAllCoroutines();

        hltext.text = "Thank you for saving the world !";
        
        yield return new WaitForSeconds(7f);
        StopAllCoroutines();

    }


    public void icemodel()
    {
        hltext.text = "Take the ice stone to stop the snow storm !";
        icemd.SetActive(true);
        return;
    }
    public void firemodel()
    {
        hltext.text = "PLease stop the fire, by taking this burning stone";
        icemd.SetActive(false);
        firemd.SetActive(true);
        return;
    }
}
    
