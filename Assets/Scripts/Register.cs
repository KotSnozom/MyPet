using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Pols
{
    public string pol;
    public Toggle toggle;
}

public class Register : MonoBehaviour
{
    [SerializeField] private Pols[] Pol = new Pols[2];
    [SerializeField] private InputField[] inputs = new InputField[3]; //вид порода им€ день рождени€
    [SerializeField] private Dropdown day,month,year;
    private int Countday = 31, Countmonth = 12, Countyear;

    private void Start()
    {
        Countyear = System.DateTime.Now.Year - 2000;
        DateCount(day,Countday);
        DateCount(month, Countmonth);
        DateCount(year, Countyear);
    }
    public void RegisterAnimal()
    {
        PlayerPrefs.DeleteAll();

        foreach (var p in Pol)
        {
            if (p.toggle.isOn)
            {
                PlayerPrefs.SetString("Pol", p.pol);
                Debug.Log(PlayerPrefs.GetString("Pol"));
            }
        }
        foreach (var p in inputs)
        {
            if (p.text != "") PlayerPrefs.SetString($"Node_{p.name}",p.text);
            else PlayerPrefs.SetString($"Node_{p.name}", "Ќе незначенно");
            Debug.Log(PlayerPrefs.GetString($"Node_{p.name}"));
        }
    }
    private void DateCount(Dropdown dropdown,int count)
    {
        for (int i = 0; i <= count; i++) 
        {
            dropdown.options.Add(new Dropdown.OptionData(i.ToString()));
        }
    }
}
