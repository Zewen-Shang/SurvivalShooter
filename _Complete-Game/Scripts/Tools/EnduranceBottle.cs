using UnityEngine;


namespace CompleteProject{

public class EnduranceBottle : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void OnTriggerEnter(Collider other){
        if(other.gameObject == player){
            player.GetComponentInChildren<PlayerShooting>().changeDamage(50);
            Destroy(gameObject);
        }

    }
    void Update()
    {
        
    }
}

}

