using UnityEngine;

namespace CompleteProject{

public class HealthBottle : MonoBehaviour
{
    public GameObject player;
    int cureAmount = 20;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void OnTriggerEnter(Collider other){
        if(other.gameObject == player){
            player.GetComponent<PlayerHealth>().TakeCured(cureAmount);
        }
        Destroy(gameObject);
    }
    void Update()
    {
        
    }
}

}

