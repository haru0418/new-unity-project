using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPplayer : MonoBehaviour
{
    //public GameObject hpGameObject;
    public Text hpText;
    void Start()
    {
        // Text text = hpGameObject.GetComponent<Text>();
        //text.text = "50";
        hpText.text = "50";
    }
}
