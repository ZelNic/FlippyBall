using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

}

[System.Serializable]
public class Decorator // хранит информацию обо всех значках, описанных в ’ћЋ - документе, определ€ющих достоинство и используемых дл€ оформлени€
{
    public string type;
    public Vector3 loc;
    public float scale = 1f;
    public bool flip;
}

[System.Serializable]
public class CardDefinition // хранит информацию о позици€х всех српрайтов на карте каждого достоинсва 
{
    public string face;
    public int rank;
    public List<Decorator> pips = new();
}