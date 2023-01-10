using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Laury
{

    public class taper : MonoBehaviour
    {
        public Transform initialParent;
        public SpriteRenderer spriteCombo;
        public Sprite combo1;
        public Sprite combo2;
        public Sprite combo3;
        public Image p1;
        public Image p2;
        public Image p3;
        public Image p4;
        public Image p5;
        public Image p6;
        public Image p7;
        private Vector3 baseTaper;
        private float baseRX;
        private float baseRY;
        private float baseRZ;
        public int points = 0;
        private bool inputTaper = false;
        public int combo = 0;
        private float angle = 60;
        private float timer;
        public float limita = 0.2f;
        void Start()
        {
            baseRX = -90;
            baseRY = 0;
            baseRZ = 0;
        }
        void Update()
        {
            timer += Time.deltaTime;
            if (timer >= limita) { combo = 0; timer = 0; }

            if (points >= 100)
            {
                p1.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            if (points >= 250)
            {
                p2.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            if (points >= 350)
            {
                p3.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            if (points >= 500)
            {
                p4.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            if (points >= 650)
            {
                p5.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            if (points >= 850)
            {
                p6.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            if (points >= 1000)
            {
                p7.color = Color.green;
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
            }
        }
        public void Tape()
        {
            if (inputTaper == false)
            {
                baseTaper = new Vector3(initialParent.eulerAngles.x + angle, initialParent.eulerAngles.y, initialParent.eulerAngles.z);
                initialParent.eulerAngles = baseTaper;
                if (combo <= 5)
                {
                    inputTaper = true;
                    points+= 1;
                    Debug.Log("TAP");
                    combo+=1;
                    spriteCombo.sprite = combo1;
                }
                if (combo <= 10)
                {
                    inputTaper = true;
                    points += 5;
                    Debug.Log("BOUM");
                    combo += 1;
                    spriteCombo.sprite = combo2;
                }
                if (combo >= 10)
                {
                    inputTaper = true;
                    points += 10;
                    Debug.Log("KABOUM");
                    spriteCombo.sprite = combo3;
                }
                timer = 0;
            }
        }
        public void ResetTape()
        {
            inputTaper = false;
            baseTaper = new Vector3(baseRX, baseRY,baseRZ);
            initialParent.eulerAngles = baseTaper;
            spriteCombo.sprite = combo1;
        }

    }
}
