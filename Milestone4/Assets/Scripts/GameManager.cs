using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] textPrefabs;
    [SerializeField]
    private Button option1, option2;

    private BinaryNode adventure;
    private List<GameObject> story;


    private int index = 0;
    private bool isPlaying;

    // Start is called before the first frame update
    void Start()
    {
        resetGame();
     
        adventure.Insert(story, index, adventure);

        while(adventure.Value != null)
        {

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void resetGame()
    {
        isPlaying = false;
        option1.GetComponentInChildren<Text>().text = "Option 1";
        option2.GetComponentInChildren<Text>().text = "Option 2";
        option1.gameObject.SetActive(true);
        option2.gameObject.SetActive(true);

    }





}
