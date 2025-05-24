using System;
using Microsoft.Xna.Framework;

namespace Library.Graphics;

public class AnimatedSprite : Sprite
{
    // VARIABLES
    private int _currentFrame;
    private TimeSpan _elapsed;
    private Animation _animation;

    /// <summary>
    /// Gets or Sets the animation for this animated sprite.
    /// </summary>
    public Animation Animation
    {
        get => _animation;
        set
        {
            _animation = value;
            Region = _animation.Frames[0];
        }
    }
    
    // CONSTRUCTORS
    /// <summary>
    /// Creates a new animated sprite.
    /// </summary>
    public AnimatedSprite() { }

    /// <summary>
    /// Creates a new animated sprite with the specified frames and delay.
    /// </summary>
    /// <param name="animation">The animation for this animated sprite.</param>
    public AnimatedSprite(Animation animation) { Animation = animation; }
    
    /// <summary>
    /// Updates this animated sprite.
    /// </summary>
    /// <param name="gameTime">A snapshot of the game timing values provided by the framework.</param>
    public void Update(GameTime gameTime)
    {
        _elapsed += gameTime.ElapsedGameTime;

        // If elapsed time is less then delay to next frame, return early
        if (_elapsed < _animation.Delay) return;
        
        _elapsed -= _animation.Delay;
        _currentFrame++;

        // If the current frame is greater than the number of frames, set the current frame to zero
        if (_currentFrame >= _animation.Frames.Count) { _currentFrame = 0; }

        // Update region to use the current frame
        Region = _animation.Frames[_currentFrame];
    }
}