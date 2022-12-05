using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Julien
{

    public class DioBanane : MonoBehaviour
    {

        public Shove shove;
        public RectTransform rt;

        private void Update()
        {
            transform.position += transform.right;
        }



    }

}