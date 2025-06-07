using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using Library;
using Library.Graphics.Data;
using Library.Physics.Components;
using Massive;

namespace Drifters;

public class Game : Core
{
    public Game() : base("Drifters", 1280, 720, false)
    {
        
    }

    protected override void Initialize()
    {
        base.Initialize();
        
        var World = new MassiveWorld();
        int Character = World.Create();
        World.Add<TextureRegion>(Character);
        World.Add<Transform>(Character);
    }

    protected override void LoadContent()
    {
        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        
        

        base.Draw(gameTime);
    }
}