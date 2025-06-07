using System.Drawing;
using Massive;
using Microsoft.Xna.Framework.Graphics;

namespace Library.Graphics.Data;

public struct TextureRegion
{
    /// <summary>
    /// Gets or Sets the source texture this texture region is part of.
    /// </summary>
    public Texture2D Texture { get; set; }

    /// <summary>
    /// Gets or Sets the source rectangle boundary of this texture region within the source texture.
    /// </summary>
    public Rectangle SourceRectangle { get; set; }

    /// <summary>
    /// Gets the width, in pixels, of this texture region.
    /// </summary>
    public int Width
    {
        get => SourceRectangle.Width;
    }

    /// <summary>
    /// Gets the height, in pixels, of this texture region.
    /// </summary>
    public int Height => SourceRectangle.Height;

    [DefaultValue]
    public static TextureRegion Default => new TextureRegion()
    {
        Texture = null,
        SourceRectangle = Rectangle.Empty,
    };
}