using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime;

    float timer;

    // Update is called once per frame
    void Update()
    {
        DrawConstellation();
    }

    void DrawConstellation()
    {
        // I created a timer variable that will increment by deltaTime
        timer += Time.deltaTime;

        // If the timer is less than the drawing time, draw the line from the first star to the second
        if (timer <= drawingTime)
        {
            Debug.DrawLine(starTransforms[0].position,
                starTransforms[1].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time and less than drawing time * 2,
        draw the line from the second star to the third */
        else if (timer > drawingTime && timer < drawingTime * 2)
        {
            Debug.DrawLine(starTransforms[1].position,
                starTransforms[2].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 2 and less than drawing time * 3,
        draw the line from the third star to the fourth */
        else if (timer >= drawingTime * 2 && timer < drawingTime * 3)
        {
            Debug.DrawLine(starTransforms[2].position,
                starTransforms[3].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 3 and less than drawing time * 4,
        draw the line from the fourth star to the fifth */
        else if (timer >= drawingTime * 3 && timer < drawingTime * 4)
        {
            Debug.DrawLine(starTransforms[3].position,
                starTransforms[4].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 4 and less than drawing time * 5,
        draw the line from the fifth star to the sixth */
        else if (timer >= drawingTime * 4 && timer < drawingTime * 5)
        {
            Debug.DrawLine(starTransforms[4].position,
                starTransforms[5].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 5 and less than drawing time * 6,
        draw the line from the sixth star to the seventh */
        else if (timer >= drawingTime * 5 && timer < drawingTime * 6)
        {
            Debug.DrawLine(starTransforms[5].position,
                starTransforms[6].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 6 and less than drawing time * 7,
        draw the line from the seventh star to the eighth */
        else if (timer >= drawingTime * 6 && timer < drawingTime * 7)
        {
            Debug.DrawLine(starTransforms[6].position,
                starTransforms[7].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 7 and less than drawing time * 8,
        draw the line from the eighth star to the ninth */
        else if (timer >= drawingTime * 7 && timer < drawingTime * 8)
        {
            Debug.DrawLine(starTransforms[7].position,
                starTransforms[8].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 8 and less than drawing time * 9,
        draw the line from the ninth star to the tenth */
        else if (timer >= drawingTime * 8 && timer < drawingTime * 9)
        {
            Debug.DrawLine(starTransforms[8].position,
                starTransforms[9].position, Color.green);
        }

        /* Else if the timer is greater than the drawing time * 9 and less than drawing time * 10,
        draw the line from the tenth star to the eleventh */
        else if (timer > drawingTime * 9 && timer < drawingTime * 10)
        {
            Debug.DrawLine(starTransforms[9].position,
                starTransforms[10].position, Color.green);

            // Reset timer to 0 to restart drawing the line from the first star to the second star
            timer = 0.0f;
        }
    }
}
