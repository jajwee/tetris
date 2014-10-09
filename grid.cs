using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Grid
{
    
    public Grid()
    {
        
    }

    public void LoadContent()
    {
        
    }

    public void Update()
    {

    }

    public void Draw(SpriteBatch s, Texture2D block)
    {
        int x = 0, y = 0;
        for (int i = 0; i < 240; i++)
        {
            s.Draw(block, new Vector2(x * block.Width, y * block.Height), Color.White);
            x++;
            if (x >= 12)
            {
                x = 0;
                y++;
            }
        }
    }

}
