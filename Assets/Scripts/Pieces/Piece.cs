using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{

    public enum Type
    {
        Brick,
        Wood,
        Stone,
        Sheep,
        Wheat
    }

    public Type type;
    private Vertex[] verts;
    private Edge[] edges;

    private const int NUM_EDGES = 6;
    private const int NUM_VERTS = 6;
    public Piece()
    {
        verts = new Vertex[NUM_VERTS];
        edges = new Edge[NUM_EDGES];
        for (int i = 0; i < NUM_VERTS; ++i)
        {
            verts[i] = new Vertex();
            verts[i].add_piece(this);
        }
        for (int i = 0; i < NUM_EDGES; ++i)
        {
            edges[i] = new Edge();    
        } 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
