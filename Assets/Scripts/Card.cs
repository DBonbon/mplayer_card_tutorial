using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card : MonoBehaviour
{
    //card identifier
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public string cardDiscription;



    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Power, string CardDiscription)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        cardDiscription = CardDiscription;
    }

}
