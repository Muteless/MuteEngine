using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Libraries
using Library;
using Library.Graphics;

namespace Game;

public class Game : Core
{
    // Texture region that defines the slime sprite in the atlas.
    private TextureRegion _slime;

    // Texture region that defines the bat sprite in the atlas.
    private TextureRegion _bat;
    
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
        
        // Retrieve the slime region from the atlas
        _slime = atlas.GetRegion("slime");
        
        // Retrieve the bat region from the atlas
        _bat = atlas.GetRegion("bat");
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
        
        // Draw the slime texture region at a scale of 4.0
        _slime.Draw(SpriteBatch, Vector2.Zero, Color.White, 0.0f, Vector2.Zero, 4.0f, SpriteEffects.None, 0.0f );
        
        // Draw the bat texture region 10 px to the right of the slime at a scale of 2.0
        _bat.Draw(SpriteBatch, new Vector2(_slime.Width * 4.0f + 10, 0), Color.White, 0.0f, Vector2.One, 4.0f, SpriteEffects.None, 0.0f);
        
        // Always end the sprite batch when finished
        SpriteBatch.End();

        base.Draw(gameTime);
    }
}