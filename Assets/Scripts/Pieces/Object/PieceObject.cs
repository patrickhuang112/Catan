using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceObject : MonoBehaviour
{

    private Piece piece;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void set_piece(Piece piece)
    {
        this.piece = piece;
    }

    public Piece get_piece()
    {
        return this.piece;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
