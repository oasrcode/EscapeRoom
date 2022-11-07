using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    
    public int TotalNotes
    {
        get { return totalnotes; }
    }
    [SerializeField]
    private int totalnotes;
    public int PlayerNotes
    {
        get { return playerNotes; }
        set { playerNotes += value; }
    }
    private int playerNotes = 0;

    [SerializeField]
    private GameObject door;

    [SerializeField]
    private GameObject panelEnd;

   [SerializeField]
    private TextMeshProUGUI textLabel;
    public TextMeshProUGUI TextLabel
    {
        get { return textLabel; }
        set { textLabel = value; }
    }

    [SerializeField]
    private List<GameObject> spawns = new List<GameObject>(6);

    [SerializeField]
    private GameObject[] notebooks = new GameObject[3];

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("more than 1 gamemanager");
        }

       
    }


    void Start()
    {
        for (int i = 0; i <= notebooks.Length; i++)
        {
            int random = Random.Range(1, spawns.Count);
            notebooks[i].transform.position = spawns[random].transform.position;
            spawns.RemoveAt(i);
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        EndEscapeRoom();
       
        
    }

    private void EndEscapeRoom()
    {
        if (totalnotes == playerNotes)
        {
            Debug.Log("Fin de la partida");

            door.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
            panelEnd.SetActive(true);
        }
    }
}
