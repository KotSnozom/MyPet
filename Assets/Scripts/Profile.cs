using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profile : MonoBehaviour
{
    public Text NameText,ViewText, BreedText;
    private void OnEnable()
    {
        NameText.text = PlayerPrefs.GetString("Node_Name");
        ViewText.text = PlayerPrefs.GetString("Node_View");
        BreedText.text = PlayerPrefs.GetString("Node_Breed");
    }
}
