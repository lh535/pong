using Avalonia;

namespace Pong.Models.GameObject;

public class GameObject 
{
    private string _id;
    private Point _pos;  // top right of object
    private Rect _bounds;

    public GameObject(string id, Point pos, Rect bounds) 
    {
        _id = id;
        _pos = pos;
        _bounds = new Rect(pos, bounds.Size);
    }

    internal void Move(Point direction)
    {
        _pos += direction;

    }
}