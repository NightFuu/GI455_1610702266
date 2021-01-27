using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    
         public string MyName;
         public GameObject ShowText;
         public GameObject Poptext;
 
    public void StoreName()
    {
        MyName = ShowText.GetComponent<Text>().text;
        Poptext.GetComponent<Text>().text =  MyName +  " Google is found ";
    }

}
