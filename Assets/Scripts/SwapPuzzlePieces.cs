using UnityEngine;

public class SwapPuzzlePieces : MonoBehaviour
{
    private Transform selectedPiece1; // First selected puzzle piece
    private Transform selectedPiece2; // Second selected puzzle piece

    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // Check if the touch hits a puzzle piece
            if (touch.phase == TouchPhase.Began)
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
                if (hit.collider != null)
                {
                    if (selectedPiece1 == null)
                    {
                        // If no first piece is selected, select the touched piece
                        selectedPiece1 = hit.collider.transform;
                    }
                    else if (selectedPiece2 == null)
                    {
                        // If no second piece is selected, select the touched piece
                        selectedPiece2 = hit.collider.transform;

                        // Swap the selected pieces
                        SwapPieces(selectedPiece1, selectedPiece2);

                        // Reset selected pieces
                        selectedPiece1 = null;
                        selectedPiece2 = null;
                    }
                }
            }
        }
    }

    // Function to swap the positions of two puzzle pieces
    void SwapPieces(Transform piece1, Transform piece2)
    {
        Vector3 tempPos = piece1.position;
        piece1.position = piece2.position;
        piece2.position = tempPos;
    }
}
