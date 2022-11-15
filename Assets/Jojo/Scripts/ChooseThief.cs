using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Jojo
{

public class ChooseThief : MonoBehaviour
{
    public List<ThiefMovement> ListThief;
    int randomThief;
    int randomMove;
    private float compteur;
    public int cooldown;
    // Start is called before the first frame update
    void Start()
    {
        compteur = cooldown;
        randomThief = Random.Range(0,ListThief.Count);
        randomMove = Random.Range(0,1);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(randomMove);
        if (compteur > 0)
            {
                compteur -= Time.deltaTime;
        }else
            {
            if(randomMove==0){
                ListThief[randomThief].BigMove=true;
            }

            if(randomMove==1 || randomMove==2 ){
                ListThief[randomThief].SmallMove=true;
            }
            randomThief = Random.Range(0,ListThief.Count);
            randomMove = Random.Range(0,2);
            compteur = cooldown;
            }
    }
}

}
