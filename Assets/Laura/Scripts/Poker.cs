using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Laury
{

    public class Poker : MonoBehaviour
    {
        public List<Cartes> Cartes;
        public int IndexInstance;
        public int ChoixCarte;
        private int Aleatoire;
        public Material Carte1, Carte2, Carte3, Carte4, CarteInconnue;
        public MeshRenderer CarteImite;
        private int Tour=1;
        public int Points;
        public float TempsApparition;
        public float Delai;
        void Start()
        {
            Delai = 5f;
            Points = 0;
            SelectionCarte(0);
        }
        void Update()
        {
            TempsApparition += Time.deltaTime;
            if (Tour < Points)
            {
                if (Delai > TempsApparition)
                {
                    Aleatoire = Random.Range(1, 5);
                    print(Aleatoire);
                    ChoixCarte = Aleatoire;
                    AfficheCarte();
                    Tour += 1;
                    Points += 1;
                }
                else 
                { 
                    CarteImite.material = CarteInconnue;
                    Tour += 1;
                }
            }

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (IndexInstance == 3){ IndexInstance = -1; }
                SelectionCarte(IndexInstance + 1); 
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (IndexInstance == 0) { IndexInstance = 4; }
                SelectionCarte(IndexInstance - 1); 
            }
        }
        public void SelectionCarte(int index)
        {
            foreach (var card in Cartes)
            {
                card.ChangeColor(Color.white);
                card.ResetPosition();
            }

            IndexInstance = index;
            Cartes[index].ChangeColor(Color.yellow);
            Cartes[index].ChangePosition();
        }
        public void AfficheCarte()
        {
            if (ChoixCarte == 1)
            {
                CarteImite.material = Carte1;
            }
            if (ChoixCarte == 2)
            {
                CarteImite.material = Carte2;
            }
            if (ChoixCarte == 3)
            {
                CarteImite.material = Carte3;
            }
            if (ChoixCarte == 4)
            {
                CarteImite.material = Carte4;
            }
        }

        public void Verif()
        {
            if (IndexInstance + 1 == ChoixCarte)
            {
                Debug.Log("C'EST BON MON POTE");
                Points += 1;
            }
            else
            {
                Debug.Log("NON, C'EST PAS LA BONNE");
                TempsApparition = 0;
            }
        }
    }
}
