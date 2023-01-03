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
            }

            Debug.Log(collision.impulse);

            forceImpact =(collision.impulse.y );
<<<<<<< HEAD
            finalImpact = (forceImpact / 50);
=======
<<<<<<< HEAD
            finalImpact = (forceImpact / 700);
=======
            finalImpact = (forceImpact / 350);
>>>>>>> 64997336b5696398cbbe8a8db1898037cc70f767
>>>>>>> 5c93ee58cdf63ddccd59a1d24dc3e6fb9aa7539e


            //if (localScale == new Vector3(1F, 0F, 1f));
            {
                //object.Destroy(Cube);
            }
        }
    }
}

//if (gameObject.tag.Equals("upper") == true)