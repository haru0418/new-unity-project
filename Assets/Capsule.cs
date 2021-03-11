using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Capsule : MonoBehaviour
{
    public Text hpText; 
    public Slider hpSlider;
    void Start()
    {
        hpText.text = "50";
        hpSlider.value = 50;
    }

    void Update()
    {
        // Transform tf = GetComponent<Transform>();
        transform.position += new Vector3(10f, 0, 0);
    }
}
