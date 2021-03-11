using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text HPText = GetComponent<Text>();
        HPText.text = "5000";
        HPText.color = new Color(1f, 0f, 0f, 1f);
    }
}
