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

namespace TopDownRPG3.UI
{
    public class VirtualCursor : SyncScript
    {
        public SpriteSheet MouseImage;

        private Button cursor;
        private ImageElement cursorElement;
        private Vector2 backBufferSize;
        private Vector3 cursorSize;

        public override void Start()
        {
            Game.Window.AllowUserResizing = false;
            Game.IsMouseVisible = false;
            backBufferSize = new Vector2(GraphicsDevice.Presenter.BackBuffer.Width, GraphicsDevice.Presenter.BackBuffer.Height);
            cursorElement = new ImageElement { Source = SpriteFromSheet.Create(MouseImage, "mouse_cursor") };
            var cursorSprite = (SpriteFromTexture)MouseImage["mouse_cursor"];
            cursorSize = new Vector3(MouseImage["mouse_cursor"].SizeInPixels.X,
               MouseImage["mouse_cursor"].SizeInPixels.Y, 0);
            cursorElement.SetCanvasPinOrigin(new Vector3(0, 0, 1));
            cursor = new Button { PressedImage = cursorSprite, NotPressedImage = cursorSprite, Size = cursorSize };
            var rootElement = new Canvas()
            {
                Children = { cursorElement },
                MaximumWidth = backBufferSize.X,
                MaximumHeight = backBufferSize.Y
            };

            Entity.Get<UIComponent>().Page = new UIPage { RootElement = rootElement };
        }
        public override void Update()
        {
            var drawX = 500;
            var drawY = 200;

            DebugText.Print("Mouse position is " + Input.MousePosition, new Int2(drawX - 300, drawY));
            cursorElement.SetCanvasRelativePosition(new Vector3(Input.Mouse.Position.X, Input.Mouse.Position.Y, 0f));
        }
    }
}
