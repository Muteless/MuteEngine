﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ECS.Graphics.Components;

public struct SpriteTexture { public Texture2D Texture; }
public struct SpriteSourceRectangle { public Rectangle SourceRectangle; }
public struct SpriteColor { public Color Color; }
public struct Transform2D { public Matrix Transform; } 

//
// public struct SpriteTexture
// {
//     /// <summary>
//     /// Gets or Sets the source texture this texture region is part of.
//     /// </summary>
//     public Texture2D Texture { get; set; }
//
//     /// <summary>
//     /// Gets or Sets the source rectangle boundary of this texture region within the source texture.
//     /// </summary>
//     public Rectangle SourceRectangle { get; set; }
//
//     /// <summary>
//     /// Gets the width, in pixels, of this texture region.
//     /// </summary>
//     public int Width => SourceRectangle.Width;
//
//     /// <summary>
//     /// Gets the height, in pixels, of this texture region.
//     /// </summary>
//     public int Height => SourceRectangle.Height;
//     
//     /// <summary>
//     /// Creates a new texture region.
//     /// </summary>
//     public TextureRegionComponent() { }
//
//     /// <summary>
//     /// Creates a new texture region using the specified source texture.
//     /// </summary>
//     /// <param name="texture">The texture to use as the source texture for this texture region.</param>
//     /// <param name="x">The x-coordinate position of the upper-left corner of this texture region relative to the upper-left corner of the source texture.</param>
//     /// <param name="y"><The y-coordinate position of the upper-left corner of this texture region relative to the upper-left corner of the source texture./param>
//     /// <param name="width">The width, in pixels, of this texture region.</param>
//     /// <param name="height">The height, in pixels, of this texture region.</param>
//     public TextureRegionComponent(Texture2D texture, int x, int y, int width, int height)
//     {
//         Texture = texture;
//         SourceRectangle = new Rectangle(x, y, width, height);
//     }
// }