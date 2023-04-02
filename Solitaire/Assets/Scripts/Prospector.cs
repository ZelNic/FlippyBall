using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// �����, ������� ��������� ���� ����� 
/// </summary>
public class Prospector : MonoBehaviour
{
    static public Prospector S;
   

    [Header("Set in Inspector")]
    public TextAsset deckXML;
    
    [Header("Set Dynamically")]
    public Deck deck;


    private void Awake()
    {
        S = this;
    }

    private void Start()
    {
        deck = GetComponent<Deck>();
        deck.InitDeck(deckXML.text);                           
    }
}
