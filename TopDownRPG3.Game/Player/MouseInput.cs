using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stride.Core.Mathematics;
using Stride.Input;
using Stride.Engine;
using Stride.Graphics;
using Stride.UI.Controls;
using Stride.Rendering.Sprites;
using Stride.UI;
using Stride.UI.Panels;

namespace TopDownRPG3.Player
{
    public class MouseInputScript : SyncScript
    {
        public SpriteSheet MouseImage;

        private Button cursor;
        private Vector2 backBufferSize;
        private Vector3 cursorSize;
        //TransformComponent mouseTransform;

        public override void Start()
        {
            Game.Window.AllowUserResizing = false;
            Game.IsMouseVisible = false;
            backBufferSize = new Vector2(GraphicsDevice.Presenter.BackBuffer.Width, GraphicsDevice.Presenter.BackBuffer.Height);
            var cursorSprite = (SpriteFromTexture)MouseImage["mouse_cursor"];
            cursorSize = new Vector3(MouseImage["mouse_cursor"].SizeInPixels.X,
               MouseImage["mouse_cursor"].SizeInPixels.Y, 0);
            cursor = new Button { PressedImage = cursorSprite, NotPressedImage = cursorSprite, Size = cursorSize };
            var rootElement = new Canvas()
            {
                Children = { cursor },
                MaximumWidth = backBufferSize.X,
                MaximumHeight = backBufferSize.Y
            };

            Entity.Get<UIComponent>().Page = new UIPage { RootElement = rootElement };
        }
        public override void Update()
        {
            var drawX = 500;
            var drawY = 200;
        //If the left mouse button is pressed in this update, do something.
            //if (Input.IsMouseButtonDown(MouseButton.Left))
            //{   
            //}
            ////If the middle mouse button has been pressed since the last update, do something.
            //if (Input.IsMouseButtonPressed(MouseButton.Middle))
            //{  
            //}
    
            //If the mouse moved more than 0.2 units of the screen size in X direction, do something.
            //if (Input.MouseDelta.X > 0.2f)
            //{
            //    DebugText.Print("MouseMoved!", new Int2(drawX, drawY));
            //}
            DebugText.Print("Mouse position is " + Input.MousePosition, new Int2(drawX - 300, drawY));
            cursor.SetCanvasAbsolutePosition(new Vector3(Input.Mouse.Position.X * backBufferSize.X - (cursorSize.X/4), Input.Mouse.Position.Y * backBufferSize.Y, 0f)); 
        }
    }
}
