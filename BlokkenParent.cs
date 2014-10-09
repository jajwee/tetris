using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class BlokkenParent
{
    protected Vector2 position = Vector2.Zero, baseposition = new Vector2(5, 0);
    protected bool[,] construction;
    Texture2D blok; 
    protected Color kleur;
    float futurepos;
    int timer2 = 0;

    public BlokkenParent(Texture2D block)
    {
        construction = new bool[4, 4];
        blok = block;
        position = baseposition * block.Height;
        futurepos = block.Height;
    }

    public void BlokkenMovement(GameTime gt, Texture2D block)
    {
        if (position.Y < futurepos)
        {
            position.Y += 2;
        }
        
        int timer1 = gt.TotalGameTime.Seconds;
        if (timer1 != timer2)
        {
            futurepos = block.Height + position.Y;
        }

        timer2 = timer1;
    }

    public void DrawConstruction(SpriteBatch s)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (construction[i, j])
                {
                    s.Draw(blok, new Vector2((position.X + (i * blok.Width)), (position.Y + (j * blok.Width))), kleur);
                }
            }
        }
    }
}
