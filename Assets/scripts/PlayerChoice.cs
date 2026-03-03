using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class PlayerChoice : MonoBehaviour
{
    // 0 = rock, 1 = paper, 2 = scissors
    
    public Sprite[] spritesToChooseFrom;

    public Button rockButton;
    public Button paperButton;
    public Button scissorsButton;

    public int playerChoice = -1;

    public TextMeshProUGUI playerChoiceText;

    public AIchoice aiChoiceScript;

    public void RockButton() 
    {
        playerChoice = 0;
        playerChoiceText.text = "Player used ROCK!";
        rockButton.gameObject.SetActive(false); paperButton.gameObject.SetActive(false); scissorsButton.gameObject.SetActive(false);

        aiChoiceScript.playButton.interactable = true;
    }

    public void PaperButton()
    {
        playerChoice = 1;
        playerChoiceText.text = "Player used PAPER!";
        rockButton.gameObject.SetActive(false); paperButton.gameObject.SetActive(false); scissorsButton.gameObject.SetActive(false);

        aiChoiceScript.playButton.interactable = true;
    }

    public void ScissorsButton()
    {
        playerChoice = 2;
        playerChoiceText.text = "Player used SCISSORS!";
        rockButton.gameObject.SetActive(false); paperButton.gameObject.SetActive(false); scissorsButton.gameObject.SetActive(false);

        aiChoiceScript.playButton.interactable = true;
    }
}
