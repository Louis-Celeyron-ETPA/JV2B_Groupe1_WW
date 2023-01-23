using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Paolo
{
    public class turn : MonoBehaviour
    {
        public int hpgalade = 5;
        public float Timer;
        // Start is called before the first frame update
        void Start()
        {
            Timer = 15f;
        }

        // Update is called once per frame
        void Update()
        {
            Timer -= Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.eulerAngles = Vector3.zero;
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.eulerAngles = Vector3.up * 180;
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.eulerAngles = Vector3.up * 270;
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.eulerAngles = Vector3.up * 90;

            }

            if (Timer < 0 && hpgalade>0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

            if (hpgalade<=0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "poukeboule")
            {
                hpgalade = hpgalade - 1;
            }

        }
    }
}
