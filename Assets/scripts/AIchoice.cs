using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AIchoice : MonoBehaviour
{
    public Sprite[] sprites;

    public int aiChoice = -1;

    public Image aiChoiceImage;

    public PlayerChoice playerChoice;

    public TextMeshProUGUI winText;

    public Button resetButton;

    public Button playButton;

    void Start()
    {
        playButton.interactable = false;
        aiChoiceImage.gameObject.SetActive(false); 
    }

    public void PlayButton()
    {
        aiChoiceImage.gameObject.SetActive(true);

        playButton.interactable = false;

        aiChoiceImage.gameObject.SetActive(true);

        aiChoice = Random.Range(0, sprites.Length);

        aiChoiceImage.sprite = sprites[aiChoice];

        if (aiChoice == playerChoice.playerChoice)
        {
            winText.text = "It's a tie!";
        }

        if (aiChoice == 0 && playerChoice.playerChoice == 2 || aiChoice == 1 && playerChoice.playerChoice == 0 || aiChoice == 2 && playerChoice.playerChoice == 1)
        {
            winText.text = "You lost!";
        }

        if (aiChoice == 2 && playerChoice.playerChoice == 0 || aiChoice == 0 && playerChoice.playerChoice == 1 || aiChoice == 1 && playerChoice.playerChoice == 2)
        {
            winText.text = "You won!";
        }

        resetButton.gameObject.SetActive(true);
        playButton.interactable = false;

    }

    public void ResetButton()
    {
        playButton.interactable = false;
        aiChoice = -1;
        playerChoice.playerChoice = -1;

        playerChoice.rockButton.gameObject.SetActive(true); 
        playerChoice.paperButton.gameObject.SetActive(true); 
        playerChoice.scissorsButton.gameObject.SetActive(true);

        winText.text = "";
        playerChoice.playerChoiceText.text = "";
        aiChoiceImage.sprite = null;
        aiChoiceImage.gameObject.SetActive(false);

        resetButton.gameObject.SetActive(false);
        playButton.interactable = true;
    }
}
