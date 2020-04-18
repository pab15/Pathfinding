using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileFactory
{
    private Dictionary<string, Tile> _tiles = new Dictionary<string, Tile>();
    private static TileFactory _instance = null;

    private TileFactory()
    {
        _tiles.Add("OutdoorsGround_0", new Tile() { 
            Name = "Grass",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_1", new Tile()
        {
            Name = "Grass",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_2", new Tile()
        {
            Name = "Grass",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_6", new Tile()
        {
            Name = "Road",
            Weight = 5
        });
        _tiles.Add("OutdoorsGround_7", new Tile()
        {
            Name = "Road",
            Weight = 5
        });
        _tiles.Add("OutdoorsGround_8", new Tile()
        {
            Name = "Road",
            Weight = 5
        });
        _tiles.Add("OutdoorsGround_9", new Tile()
        {
            Name = "Road",
            Weight = 5
        });
        _tiles.Add("OutdoorsGround_19", new Tile()
        {
            Name = "Road",
            Weight = 5
        });
        _tiles.Add("OutdoorsGround_15", new Tile()
        {
            Name = "Rough_Road",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_11", new Tile()
        {
            Name = "Rough_Road2",
            Weight = 7
        });
        _tiles.Add("OutdoorsGround_42", new Tile()
        {
            Name = "Lake",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_43", new Tile()
        {
            Name = "Lake",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_44", new Tile()
        {
            Name = "Lake",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_45", new Tile()
        {
            Name = "Lake",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_46", new Tile()
        {
            Name = "Lake",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_47", new Tile()
        {
            Name = "Lake",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_29", new Tile()
        {
            Name = "Pond",
            Weight = -1
        });
        _tiles.Add("OutdoorsGround_36", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_38", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_30", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_32", new Tile()
        {
            Name = "Pond_Edge",
            Weight = 25
        });
        _tiles.Add("OutdoorsGround_12", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_13", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_14", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_16", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_17", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_18", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_20", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_22", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_24", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        _tiles.Add("OutdoorsGround_25", new Tile()
        {
            Name = "Path_Edge",
            Weight = 20
        });
        // Objects:
        _tiles.Add("OutdoorsObjects_0", new Tile()
        {
            Name = "Meduim_Rock",
            Weight = 35
        });
        _tiles.Add("OutdoorsObjects_1", new Tile()
        {
            Name = "Small_Rock",
            Weight = 20
        });
        _tiles.Add("OutdoorsObjects_2", new Tile()
        {
            Name = "Big_Rock",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_8", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_9", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_10", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_11", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_12", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_13", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_14", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_15", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_16", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_17", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_18", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_19", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });
        _tiles.Add("OutdoorsObjects_20", new Tile()
        {
            Name = "Bush",
            Weight = -1
        });

        _tiles.Add("Generic", new Tile()
        {
            Name = "Unknown",
            Weight = 5
        });
    }

    public static TileFactory GetInstance()
    {
        if(_instance == null)
        {
            _instance = new TileFactory();
        }
        return _instance;
    }

    public Tile GetTile(string tileName)
    {
        if (_tiles.ContainsKey(tileName))
        {
            return _tiles[tileName];
        }
        else
        {
            return _tiles["Generic"];
        }
    }
}
