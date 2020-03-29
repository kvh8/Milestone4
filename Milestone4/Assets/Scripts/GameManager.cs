using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] textPrefabs;
    [SerializeField]
    private GameObject textPosition;
    [SerializeField]
    private Button option1, option2;

    private bool op1 = false;
    private bool op2 = false;
    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        resetGame();


        BinaryNode adventure = new BinaryNode(textPrefabs[0]);
        adventure.left = new BinaryNode(textPrefabs[1]);
        adventure.right = new BinaryNode(textPrefabs[2]);
        adventure.left.left = new BinaryNode(textPrefabs[3]);
        adventure.left.right = new BinaryNode(textPrefabs[4]);
        adventure.right.left = new BinaryNode(textPrefabs[5]);
        adventure.right.right = new BinaryNode(textPrefabs[6]);
        adventure.left.left.left = new BinaryNode(textPrefabs[7]);
        adventure.left.left.right = new BinaryNode(textPrefabs[8]);
        adventure.left.right.left = new BinaryNode(textPrefabs[9]);
        adventure.left.right.right = new BinaryNode(textPrefabs[10]);
        adventure.right.left.left = new BinaryNode(textPrefabs[11]);
        adventure.right.left.right = new BinaryNode(textPrefabs[12]);
        adventure.right.right.left = new BinaryNode(textPrefabs[13]);
        adventure.right.right.right = new BinaryNode(textPrefabs[14]);
        adventure.left.right.left.left = new BinaryNode(textPrefabs[15]);
        adventure.left.right.left.right = new BinaryNode(textPrefabs[16]);
        adventure.right.right.left.left = new BinaryNode(textPrefabs[17]);
        adventure.right.right.left.right = new BinaryNode(textPrefabs[18]);
        adventure.left.right.left.right.left = new BinaryNode(textPrefabs[19]);
        adventure.left.right.left.right.right = new BinaryNode(textPrefabs[20]);
        adventure.left.right.left.right.left.left = new BinaryNode(textPrefabs[21]);
        adventure.left.right.left.right.left.right = new BinaryNode(textPrefabs[22]);
        adventure.left.right.left.right.left.right.left = new BinaryNode(textPrefabs[23]);
        adventure.left.right.left.right.left.right.right = new BinaryNode(textPrefabs[24]);



        nextChoice(adventure);
    }





   void nextChoice(BinaryNode jackpot)
    {
        while (isPlaying == true)
        {
            Instantiate(jackpot.value, textPosition.transform);

            option1.onClick.AddListener(delegate
            {
                op1 = true;
            });

            option2.onClick.AddListener(delegate
            {
                op2 = true;
            });

            if (op1 == true)
            {
                jackpot = jackpot.left;
            }
            else if (op2 == true)
            {
                jackpot = jackpot.right;
            }
        }

    }


    // Update is called once per frame
   /* void Update()
    {

    }
    */

    private void resetGame()
    {
        //Instantiate(textPrefabs[0], textPosition.transform);
        option1.gameObject.SetActive(true);
        option2.gameObject.SetActive(true);
        isPlaying = true;

    }





}
