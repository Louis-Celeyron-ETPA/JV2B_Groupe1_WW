using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Gael
{
    public class G1_MAC_02 : MonoBehaviour
    {
        public float cubeSize = .5f;
        public bool touch;
        public GameObject Cube;
        public float forceImpact ;
        public float finalImpact = 1f;


        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (touch == true)
            {
                transform.localScale = Vector3.one * cubeSize;
            }
            transform.localScale = new Vector3(1f, cubeSize, 1f);

        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "upper")
            {
                cubeSize -= finalImpact;
                cubeSize = Mathf.Clamp01(cubeSize);
            }
            if (cubeSize <= 0)
            {
                Destroy(gameObject);
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

            Debug.Log(collision.impulse);

            forceImpact =(collision.impulse.y );

            finalImpact = (forceImpact / 70);


            //if (localScale == new Vector3(1F, 0F, 1f));
            {
                //object.Destroy(Cube);
            }
        }
    }
}

//if (gameObject.tag.Equals("upper") == true)