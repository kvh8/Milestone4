using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BinaryNode : MonoBehaviour
{
	public GameObject value;


    public BinaryNode left = null;
	public BinaryNode right = null;
	public BinaryNode(GameObject v = null)
	{
		value = v;
	}

    /*void insert(BinaryNode story, GameObject[] prefabs)
    {
        int index = 0;
        while (isPlaying)
        {
            story.value = prefabs[index];
            story.left.Insert(prefabs, (2 * index) + 1);
            story.right.Insert(prefabs, (2 * index) + 2);
            index++;
        }

    }*/

    public void Insert(GameObject[] prefabs, int index)
    {
        BinaryNode adventure = new BinaryNode();
        adventure.value = prefabs[index];
        adventure.left.Insert(prefabs, (2 * index) + 1);
        adventure.right.Insert(prefabs, (2 * index) + 2);
    }


    //public void Insert(GameObject[] textPrefabs, int index, BinaryNode searchtree)
	//{
   //     searchtree.value = textPrefabs[index];
   //     searchtree.Insert(textPrefabs, (2 * index) + 1, searchtree.left);
  //      searchtree.Insert(textPrefabs, (2 * index) + 2, searchtree.right);
        

        //foreach(GameObject item in tree)
        //{
        //     if(searchtree.value == null)
        //     {
        //         searchtree.value = item;
        //     }
        //     else
        //     {
        //         searchtree.left.Insert(tree);
        //         searchtree.right.Insert(tree);
        //     }
        //}

   // }
}
