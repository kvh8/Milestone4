using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BinaryNode : MonoBehaviour
{
	private GameObject value;
    public GameObject Value { get { return this.value;} }

    BinaryNode left = new BinaryNode();
	BinaryNode right = new BinaryNode();
	public BinaryNode(GameObject v = null)
	{
		value = v;
	}



    public void Insert(List<GameObject> textPrefabs, int index, BinaryNode searchtree)
	{
        searchtree.value = value;
        searchtree.Insert(textPrefabs, (2 * index) + 1, searchtree.left);
        searchtree.Insert(textPrefabs, (2 * index) + 2, searchtree.right);
        index++; 

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

    }

}
