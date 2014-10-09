using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

class Tetris : Game
{
    SpriteBatch spriteBatch;
    GraphicsDeviceManager graphics;
    Grid grid;
    Texture2D block;
    InputHelper inputHelper;
    List<BlokkenParent> blokken;

    static void Main()
    {
        Tetris game = new Tetris();
        game.Run();
    }

    public Tetris()
    {
        Content.RootDirectory = "Content";
        graphics = new GraphicsDeviceManager(this);
        grid = new Grid();
        inputHelper = new InputHelper();
        blokken = new List<BlokkenParent>();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        block = Content.Load<Texture2D>("block");
        blokken.Add(new Blok1(block));
    }

    protected override void Update(GameTime gameTime)
    {
        inputHelper.Update(gameTime);
        foreach (BlokkenParent b in blokken)
        {
            b.BlokkenMovement(gameTime, block);            
        }
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.White);
        spriteBatch.Begin();
        grid.Draw(spriteBatch, block);
        foreach (BlokkenParent b in blokken)
        {
            b.DrawConstruction(spriteBatch);
        }
        spriteBatch.End();
    }
}
