using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BananaLover
{
    public class TempInput : MonoBehaviour
    {
        public ThrowBall tb;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                tb.Throw();
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                tb.IncreasePower();
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                tb.DecreasePower();
            }
        }
    }
}
