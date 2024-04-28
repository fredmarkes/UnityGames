using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class RandomWordGenerator : MonoBehaviour
{
    public Text randomLettersText; // Reference to the UI Text component
    public WordValidation wordValidation;

    private void Start()
    {
        Debug.Log("start");
        GenerateRandomWord();
    }

    public void GenerateRandomWord()
    {

        Debug.Log("Generating random word..."); // Log a message indicating that the function is being called


        TextAsset wordListFile = Resources.Load<TextAsset>("EnglishWordsList");
        Debug.Log("Get word list" + wordListFile); 
        
        string[] wordList = wordListFile.text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

        // Select a correct word from the word list
        string correctWord = wordList[UnityEngine.Random.Range(0, wordList.Length)];

        Debug.Log("Generated random word: " + correctWord); // Log the randomly generated word


               // Shuffle the characters of the word
        char[] charArray = correctWord.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            int randomIndex = UnityEngine.Random.Range(i, charArray.Length);
            char temp = charArray[randomIndex];
            charArray[randomIndex] = charArray[i];
            charArray[i] = temp;
        }

        // Assign the generated word to the RandomLettersText UI Text component
        randomLettersText.text = new string(charArray).ToUpper();

         // Pass the random word to the WordValidation script for validation
        wordValidation.SetRandomWord(correctWord); // Pass the random word for validation

    }

    
}
