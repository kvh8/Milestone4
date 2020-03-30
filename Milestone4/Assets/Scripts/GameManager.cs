﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] textPrefabs;
    [SerializeField]
    private GameObject textPosition, welcome;
    [SerializeField]
    private Button option1, option2, start;

    // [SerializeField]
    //private BinaryNode adventure;
    private GameObject clone;
    private bool op1 = false;
    private bool op2 = false;
    private bool isPlaying = false;
    //private BinaryNode adventure;
    int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        resetGame();

        option1.onClick.AddListener(delegate
        {
            op1 = true;
        });

        option2.onClick.AddListener(delegate
        {
            op2 = true;
        });


        GameObject clone1 = Instantiate(welcome, textPosition.transform);

        start.onClick.AddListener(delegate
        {
            Destroy(clone1);
            start.gameObject.SetActive(false);
            option1.gameObject.SetActive(true);
            option2.gameObject.SetActive(true);
            startGame();
        });
    }
    void startGame()
    {

        while (index < textPrefabs.Length)
        {
            clone = Instantiate(textPrefabs[index], textPosition.transform);

            if (op1 == true)
            {
                index = (2 * index) + 1;
            }
            else if(op2 == true)
            {
                index = (2 * index) + 2;
            }
        }

    }

        

        //adventure.Insert(textPrefabs, index, adventure);

        //Instantiate(adventure.value, textPosition.transform);



        //nextChoice(adventure);
 

        // Update is called once per frame
        /* void Update()
         {

         }
         */

    public void ChangeText(bool button, GameObject text)
    {
        if(button == false)
        {
            text.SetActive(true);
        }
        else
        {
            text.SetActive(false);
        }
    }


    private void resetGame()
    {
        //Instantiate(textPrefabs[0], textPosition.transform);
        option1.gameObject.SetActive(false);
        option2.gameObject.SetActive(false);
        start.gameObject.SetActive(true);
        isPlaying = true;

    }




    
}
/*
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
*/
