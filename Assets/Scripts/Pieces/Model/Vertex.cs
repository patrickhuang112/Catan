using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertex : MonoBehaviour
{
    private List<Piece> pieces;    

    // Start is called before the first frame update
    
    public void add_piece(Piece piece)
    {
        pieces.Add(piece); 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
