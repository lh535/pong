using Avalonia;

namespace Pong.Models.GameObject;

public class Paddle : GameObject 
{
    public Paddle(string id, Point pos, Rect bounds) : base(id, pos, bounds)
    {
        
    }
}