using Microsoft.AspNetCore.Components.Web;

public class KeyboardService
{
    public event Action<string>? OnKeyPress;
    public event Action<string>? OnKeyRelease;

    private HashSet<string> _pressedKeys = new HashSet<string>();

    public void KeyDown(KeyboardEventArgs e)
    {

        if (!_pressedKeys.Contains(e.Key))
        {
            _pressedKeys.Add(e.Key);
            OnKeyPress?.Invoke(e.Key);
        }
    }

    public void KeyUp(KeyboardEventArgs e)
    {

        if (_pressedKeys.Contains(e.Key))
        {
            _pressedKeys.Remove(e.Key);
            OnKeyRelease?.Invoke(e.Key);
        }
    }

    public bool IsKeyPressed(string key)
    {
        return _pressedKeys.Contains(key);
    }
}
