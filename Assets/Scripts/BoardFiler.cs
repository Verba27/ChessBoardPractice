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
            for (int i = 0; i < allFiguresConfig.numOf; i++)
            {
                for (int j = 0; j < allFiguresConfig.figureTypes[i].index.Length; j++)
                {
                    var fig = Instantiate(allFiguresConfig.figureTypes[i].figureInfos.prefab);
                    fig.transform.position = board.positions[allFiguresConfig.figureTypes[i].index[j]];
                    fig.transform.localScale = Vector3.one;
                    if (allFiguresConfig.figureTypes[i].index[j] < 16)
                    {
                        fig.GetComponent<Renderer>().material = allFiguresConfig.figureTypes[i].figMaterial[0]; 
                    }
                    else
                    {
                        fig.GetComponent<Renderer>().material = allFiguresConfig.figureTypes[i].figMaterial[1];
                    }
                }
            }
        }
    }
}