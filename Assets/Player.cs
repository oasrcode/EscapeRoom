using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public int notes = 0;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    private void OnTriggerEnter(Collider col)
    {
       

        if (col.gameObject.tag == "notebooks")
        {
            notes++;
            col.gameObject.SetActive(false);
            GameManager.Instance.PlayerNotes = +1;
            GameManager.Instance.TextLabel.text = "Libretas = " + notes.ToString(); ;
        }
       
            
        
    }
}
