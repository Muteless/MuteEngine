using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Libraries
using Library;
using Library.Graphics;

namespace Game;

public class Game : Core
{
    // Defines the slime animated sprite.
    private AnimatedSprite _slime;

    // Defines the bat animated sprite.
    private AnimatedSprite _bat;
    
    // Constructor
    public Game() : base("Drifters", 1280, 720, false)
    {
        
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {
        // Create a TextureAtlas instance from the atlas
        TextureAtlas atlas = TextureAtlas.FromFile(Content, "Textures/atlas-definition.xml");
        
        // Create the slime sprite from the atlas
        _slime = atlas.CreateSprite("slime");
        _slime.Scale = new Vector2(4.0f, 4.0f);
        
        // Create the bat sprite from the atlas
        _bat = atlas.CreateSprite("bat");
        _bat.Scale = new Vector2(4.0f, 4.0f);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        
        // Begin the sprite batch to prepare for rendering
        SpriteBatch.Begin();
        
        // Draw the slime
        _slime.Draw(SpriteBatch, Vector2.One);
        
        // Draw the bat
        _bat.Draw(SpriteBatch, new Vector2(_slime.Width + 10, 0));
        
        // Always end the sprite batch when finished
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}