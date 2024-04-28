using UnityEngine;
using UnityEngine.UI;

public class WordValidation : MonoBehaviour
{
    public Text userInputField; // Reference to the UI Input Field where the user inputs their answer
    public Text feedbackText; // Reference to the UI Text for providing feedback to the user
    private string correctWord; // The correct word to compare the user's input against

// Function to be called when the user presses the "Guess" button
    public void CheckAnswer()
    {
        string userAnswer = userInputField.text.ToUpper(); // Get the user's input and convert it to uppercase for case-insensitive comparison

        Debug.Log("CheckAnswer ..." + userAnswer); // Log a message indicating that the function is being called

        Debug.Log("Check correctWord ..." + correctWord); // Log a message indicating that the function is being called

        if (userAnswer == correctWord.ToUpper())
        {
            // Provide feedback to the user that their answer is correct
            feedbackText.text = "Correct!";
        }
        else
        {
            // Provide feedback to the user that their answer is incorrect
            feedbackText.text = "Incorrect. Try again!";
        }
    }

    // Function to set the correct word
    public void SetRandomWord(string word)
    {
        correctWord = word.ToLower(); // Store the correct word and convert it to lowercase for case-insensitive comparison
    }
}
