using AI_For_Games_Lab.Shapes;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_For_Games_Lab
{
    internal static class ShapeBatcherHelper
    {
    
        public static void Draw(this ShapeBatcher shapeBatcher, Shape shape)
        {
            switch (shape)
            {
                case Circle circle:
                    shapeBatcher.Draw(shape as Circle);
                    break;
                case Shapes.Rectangle rectangle:
                    shapeBatcher.Draw(shape as Shapes.Rectangle);
                        break;
                        
            
            
            }

        }

        public static void Draw(this ShapeBatcher shapeBatcher, Circle circle)
        {
            shapeBatcher.DrawCircle(circle.Position, circle.radius, 16, 2, circle.Colour);
        }

        public static void Draw(this ShapeBatcher shapeBatcher, Shapes.Rectangle rectangle)
        {
            float halfWidth = rectangle.width * 0.5f;
            float halfHeight = rectangle.height * 0.5f;
            Vector2[] corners = {
        new Vector2(rectangle.Position.X + halfWidth, rectangle.Position.Y - halfHeight),
        new Vector2(rectangle.Position.X - halfWidth, rectangle.Position.Y - halfHeight),
        new Vector2(rectangle.Position.X - halfWidth, rectangle.Position.Y + halfHeight),
        new Vector2(rectangle.Position.X + halfWidth, rectangle.Position.Y + halfHeight)};

            shapeBatcher.DrawLine(corners[0], corners[1], 2, rectangle.Colour);
            shapeBatcher.DrawLine(corners[1], corners[2], 2, rectangle.Colour);
            shapeBatcher.DrawLine(corners[2], corners[3], 2, rectangle.Colour);
            shapeBatcher.DrawLine(corners[3], corners[0], 2, rectangle.Colour);
        }

    }
}
