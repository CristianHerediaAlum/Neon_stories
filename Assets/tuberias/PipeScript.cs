// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PipeScript : MonoBehaviour
// {
//     float[] rotations = { 0,90,180,270 };

//     public float[] correctRotation;
//     [SerializeField]
//     bool isPlaced = false;

//     int PossibleRots = 1;

//     GameManager gameManager;

//     private void Awake()
//     {
//         gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
//     }

//     private void Start()
//     {
//         PossibleRots = correctRotation.Length;
//         int rand = Random.Range(0, rotations.Length);
//         transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        
//         if(PossibleRots > 1)
//         {
//             if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1])
//             {
//                 isPlaced = true;
//                 gameManager.correctMove();
//             }
//         }
//         else
//         {
//             if (transform.eulerAngles.z == correctRotation[0])
//             {
//                 isPlaced = true;
//                 gameManager.correctMove();
//             }
//         }
//     }

//     private void OnMouseDown()
//     {
//         transform.Rotate(new Vector3(0, 0, 90));

//         if (PossibleRots > 1)
//         {
//             if (transform.eulerAngles.z == correctRotation[0] || transform.eulerAngles.z == correctRotation[1] && isPlaced == false)
//             {
//                 isPlaced = true;
//                 gameManager.correctMove();
//             }
//             else if (isPlaced == true)
//             {
//                 isPlaced = false;
//                 gameManager.wrongMove();
//             }
//         }
//         else
//         {
//             if (transform.eulerAngles.z == correctRotation[0] && isPlaced == false)
//             {
//                 isPlaced = true;
//                 gameManager.correctMove();
//             }
//             else if (isPlaced == true)
//             {
//                 isPlaced = false;
//                 gameManager.wrongMove();
//             }
//         }
//     }
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    float[] rotations = { 0,90,180,270 };

    public float[] correctRotation;
    [SerializeField]
    bool isPlaced = false;

    int PossibleRots = 1;

    GameManager gameManager;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Start()
    {
        PossibleRots = correctRotation.Length;
        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);
        
        if(IsRotationCorrect(transform.eulerAngles.z))
        {
            isPlaced = true;
            gameManager.correctMove();
        }
    }

    private void OnMouseDown()
    {
        transform.Rotate(new Vector3(0, 0, 90));

        if (IsRotationCorrect(transform.eulerAngles.z) && isPlaced == false)
        {
            isPlaced = true;
            gameManager.correctMove();
        }
        else if (isPlaced == true)
        {
            isPlaced = false;
            gameManager.wrongMove();
        }
    }

    private bool IsRotationCorrect(float rotation)
    {
        rotation = NormalizeAngle(rotation);
        for (int i = 0; i < correctRotation.Length; i++)
        {
            float difference = Mathf.Abs(rotation - NormalizeAngle(correctRotation[i]));
            if (difference < 0.1f)
            {
                return true;
            }
        }
        return false;
    }

    private float NormalizeAngle(float angle)
    {
        while (angle < 0)
        {
            angle += 360;
        }
        while (angle > 360)
        {
            angle -= 360;
        }
        return angle;
    }
}
