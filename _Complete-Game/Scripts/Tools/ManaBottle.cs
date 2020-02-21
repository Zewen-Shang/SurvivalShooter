using UnityEngine;


namespace CompleteProject{

public class ManaBottle : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    private void OnTriggerEnter(Collider other){
        if(other.gameObject == player){
            player.GetComponent<PlayerMovement>().changeSpeed(10f);
            Destroy(gameObject);
        }
    }
    void Update()
    {
        
    }
}

}

