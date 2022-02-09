using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class BoardFiler : MonoBehaviour
    {
        [SerializeField] private Board board;
        [SerializeField] private AllFiguresConfig allFiguresConfig;
        
        private void Start()
        {
            for (int i = 0; i < allFiguresConfig.figureTypes.Length; i++)
            {
                for (int j = 0; j < allFiguresConfig.figureTypes[i].index.Length; j++)
                {
                    GameObject go = new GameObject();
                    if (allFiguresConfig.figureTypes[i].index[j] < board.positions.Length / 2)
                    {
                        go = Instantiate(allFiguresConfig.figureTypes[i].prefab[0]);
                    }
                    else
                    {
                        go = Instantiate(allFiguresConfig.figureTypes[i].prefab[1]);
                    }
                    go.transform.position = board.positions[allFiguresConfig.figureTypes[i].index[j]];
                    go.transform.localScale = Vector3.one;
                }
            }
        }
    }
}