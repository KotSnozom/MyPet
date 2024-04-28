using System.Collections.Generic;
using UnityEngine;

public class MedicineCards : MonoBehaviour
{
    [SerializeField] private List<GameObject> Cards;

    [SerializeField] private GameObject CardPrefab;

    [SerializeField] private GameObject CardContainer;

    [SerializeField] private GameObject rightButton, leftButton;

    private int cardIndex;


    private void Start()
    {
        if (cardIndex == 0)
        {
            leftButton.SetActive(false);
        }

        if(cardIndex == Cards.Count-1)
        {
            rightButton.SetActive(false);
        }
    }

    public void NextCard()
    {
        cardIndex++;

        for (int i = 0; i < Cards.Count; i++)
        {
            Cards[i].SetActive(false);
        }

        if(cardIndex == Cards.Count - 1)
        {
            rightButton.SetActive(false);
        }

        leftButton.SetActive(true);

        Cards[cardIndex].SetActive(true);
    }

    public void LastCard()
    {
        cardIndex--;

        for (int i = 0; i < Cards.Count; i++)
        {
            Cards[i].SetActive(false);
        }

        if (cardIndex == 0)
        {
            leftButton.SetActive(false);
        }

        rightButton.SetActive(true);

        Cards[cardIndex].SetActive(true);
    }

    public void CreateCard()
    {
        GameObject NewCard = Instantiate(CardPrefab, CardContainer.transform);

        Cards.Insert(1, NewCard);

        for (int i = 0; i < Cards.Count; i++)
        {
            Cards[i].SetActive(false);
        }

        Cards[cardIndex].SetActive(true);

        NextCard();
    }

}
