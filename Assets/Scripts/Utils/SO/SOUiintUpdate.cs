using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SOUiintUpdate : MonoBehaviour
{
    public SOint sOint;
    public TextMeshProUGUI uiTextValue;

    // Start is called before the first frame update
    void Start()
    {
        uiTextValue.text = sOint.value.ToString();  
    }

    // Update is called once per frame
    void Update()
    {
        uiTextValue.text = sOint.value.ToString(); 
    }
}
