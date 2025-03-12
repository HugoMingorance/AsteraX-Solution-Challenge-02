using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafetyZone : MonoBehaviour
{
    
    public GameObject player;
    public bool isInDanger = false;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
    }
    
    void OnTriggerStay(Collider other) {
        isInDanger = true;
        Debug.Log("HA ENTRAT ALGO");
    }
    
    void OnTriggerExit(Collider other) {
        isInDanger = false;
        Debug.Log("HA SORTIT ALGO");
    }

    /*
    public void SendisInDanger()
    {
        player.GetComponent<PlayerShip>().getIsDanger(isInDanger);
    }
    */
    
}
