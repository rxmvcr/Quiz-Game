using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    private int questionNumber;
    string[,] data = new string[10, 6];

    void Start()
    {
        data[0, 0] = "What is the capital of Japan?";
        data[0, 1] = "Moscow";
        data[0, 2] = "Pekin";
        data[0, 3] = "Tokyo";
        data[0, 4] = "London";
        data[0, 5] = "C";

        data[1, 0] = "How many fingers are on the rabbit's feet?";
        data[1, 1] = "1";
        data[1, 2] = "2";
        data[1, 3] = "3";
        data[1, 4] = "4";
        data[1, 5] = "D";

        data[2, 0] = "What is the speed of light in km/h";
        data[2, 1] = "100";
        data[2, 2] = "200";
        data[2, 3] = "300";
        data[2, 4] = "400";
        data[2, 5] = "C";

        data[3, 0] = "Jesus was born in ...";
        data[3, 1] = "October";
        data[3, 2] = "January";
        data[3, 3] = "February";
        data[3, 4] = "April";
        data[3, 5] = "B";

        data[4, 0] = "How tall is Chris Evans?";
        data[4, 1] = "1.83 m";
        data[4, 2] = "1.77 m";
        data[4, 3] = "2.00 m";
        data[4, 4] = "1.91 m";
        data[4, 5] = "A";

        data[5, 0] = "Who wrote Borodino?";
        data[5, 1] = "Tolstoy";
        data[5, 2] = "Pushkin";
        data[5, 3] = "Lermontov";
        data[5, 4] = "Bunin";
        data[5, 5] = "C";

        data[6, 0] = "Who is Dmitry Mendeleev?";
        data[6, 1] = "A chemist";
        data[6, 2] = "A prosaic";
        data[6, 3] = "A baseball player";
        data[6, 4] = "A politician";
        data[6, 5] = "A";

        data[7, 0] = "What's the name of Newton";
        data[7, 1] = "Leo";
        data[7, 2] = "Mark";
        data[7, 3] = "Alex";
        data[7, 4] = "Isaac";
        data[7, 5] = "D";

        data[8, 0] = "Who is Luigi's brother?";
        data[8, 1] = "Link";
        data[8, 2] = "Mario";
        data[8, 3] = "Drake";
        data[8, 4] = "Eminem";
        data[8, 5] = "B";

        data[9, 0] = "Harry Potter's wife is ...";
        data[9, 1] = "Hermione Granger";
        data[9, 2] = "Luna Lovegood";
        data[9, 3] = "Nymphadora Tonks";
        data[9, 4] = "Ginny Weasley";
        data[9, 5] = "D";
    }

    // Update is called once per frame
    void Update()
    {
        if (displayingQuestion == false)
        {
            questionNumber = Random.Range(0, 10);

            displayingQuestion = true;

            QuestionDisplay.newQuestion = data[questionNumber, 0];
            QuestionDisplay.newA = data[questionNumber, 1];
            QuestionDisplay.newB = data[questionNumber, 2];
            QuestionDisplay.newC = data[questionNumber, 3];
            QuestionDisplay.newD = data[questionNumber, 4];

            actualAnswer = data[questionNumber, 5];

            QuestionDisplay.pleaseUpdate = false;
        }
    }


}
