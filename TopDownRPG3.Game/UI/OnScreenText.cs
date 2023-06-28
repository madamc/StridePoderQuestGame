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
using Stride.UI;
using Stride.UI.Panels;
using TopDownRPG3.Core;
using Stride.Rendering.Sprites;

namespace TopDownRPG3.UI
{
    public class OnScreenText : SyncScript
    {
        //public Font Font { get; set; }
        public SpriteFont SpriteFont_f { get; set; }
        public SpriteFont SpriteFont_b { get; set; }
        public SpriteSheet Panel { get; set; }
        //This script doese use the below Page property, but the Entity has to have a UIPage component on it.
        public UIPage Page { get; set; }
        private TextBlock m_textBlock_f;
        private TextBlock m_textBlock_b;
        private ImageElement m_imageElement;
        private string m_text;
        public Vector3 TextPosition { get; private set; }
        private Vector3 m_position_offset;
        public override void Start()
        {
            //had issues loading a font from the file system
            //Font = Content.Load<SpriteFont>("Fonts/pcsenior");
            TextPosition = new Vector3(25, 200, 0);
            m_position_offset = new Vector3(10f, 185f, 0);
            Page = Entity.Get<UIComponent>().Page;
            m_text = "";//"Well, as far as Apple Parnibies go, these rafters seem to billowing for decades and eons now. Not that it matters... Well, as far as Apple Parnibies go, these rafters seem to billowing for decades and eons now. Not that it matters... Well, as far as Apple Parnibies go, these rafters seem to billowing for decades and eons now. Not that it matters... Well, as far as Apple Parnibies go, these rafters seem to billowing for decades and eons now. Not that it matters... Well, as far as Apple Parnibies go, these rafters seem to billowing for decades and eons now. Not that it matters...";
            m_textBlock_f = new TextBlock
            {
                Font = SpriteFont_f,
                Text = m_text,
                TextColor = Color.Aqua,
                TextSize = 20,
                WrapText = true,
                Width = 1000,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
            };
            m_textBlock_b = new TextBlock
            {
                Font = SpriteFont_b,
                Text = m_text,
                TextColor = Color.Black,
                TextSize = 30,
                WrapText = true,
                Width = 1000,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            m_imageElement = new ImageElement { Source = SpriteFromSheet.Create(Panel, "bgr_panel"), StretchType = StretchType.Fill };
            m_imageElement.Width = m_textBlock_f.Width + 10;
            m_imageElement.Height = 75;
            var rootElement = new Canvas()
            {
                Children = { m_imageElement, m_textBlock_b, m_textBlock_f },
                MaximumWidth = GraphicsDevice.Presenter.BackBuffer.Width,
                MaximumHeight = GraphicsDevice.Presenter.BackBuffer.Height
            };

            Entity.Get<UIComponent>().Page = new UIPage { RootElement = rootElement };
            m_imageElement.Visibility = Visibility.Hidden;
        }

        public override void Update()
        {
            m_textBlock_f.SetCanvasAbsolutePosition(TextPosition);
            m_imageElement.SetCanvasAbsolutePosition(m_position_offset);

            //DebugText.Print("Zoobeldorp", new Int2(300, 100));
        }

        public void setTextPosition(Vector2 position)
        {
            TextPosition = new Vector3(position.X, position.Y, 0);
            m_position_offset = new Vector3(position.X - 20f, position.Y - 20f, 0);
        }

        public void setText(string text)
        {
            if (text != m_text)
            {
                m_text = text;
                m_textBlock_b.Text = text;
                m_textBlock_f.Text = text;
            }
        }

        public void toggleBgPanel(bool on)
        {
            if (!on) { m_imageElement.Visibility = Visibility.Hidden; }
            else { m_imageElement.Visibility = Visibility.Visible; }
        }
    }
}
