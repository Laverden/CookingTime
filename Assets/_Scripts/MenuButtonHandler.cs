using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

using TMPro;

public class MenuButtonHandler : MonoBehaviour
{
    [SerializeField]
    public TMPro.TextMeshProUGUI buttonText;

    [SerializeField]
    public Color32 textColor;

    [SerializeField]
    public Color32 textHighlight;

    [SerializeField]
    public Transform parentPanel;
    [SerializeField]
    public Transform linkedPanel;
    
    
    public void OnClick()
    {
        this.parentPanel.gameObject.SetActive(false);
        this.linkedPanel.gameObject.SetActive(true);
    }

    public void IsHighlighted(bool flag)
    {
        if (flag)
        {
            buttonText.color = this.textHighlight;
        } 
        else
        {
            buttonText.color = this.textColor;
        }
        
    }
    
}
