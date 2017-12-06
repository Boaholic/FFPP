using System.Windows.Forms;
using System.Drawing;


namespace GUILayer
{
    public static class Graphics
    {
        static private readonly Bitmap hitImage = new Bitmap(GUILayer.Properties.Resources.hitImage);
        static private readonly Bitmap splashImage = new Bitmap(GUILayer.Properties.Resources.splashImage);
        static public readonly Bitmap[] deckImages = new Bitmap[4];

        static Graphics()
        {
            deckImages[0] = new Bitmap(GUILayer.Properties.Resources.deck0Image);
            deckImages[1] = new Bitmap(GUILayer.Properties.Resources.deck1Image);
            deckImages[2] = new Bitmap(GUILayer.Properties.Resources.deck2Image);
            deckImages[3] = new Bitmap(GUILayer.Properties.Resources.deck3Image);
        }

        // Opacity settings.
        private static int generalOpacity = 150;
        private static int spacialOpacity = 200;
        public static readonly Brush[] colors = new SolidBrush[8]
        {
            new SolidBrush(Color.FromArgb(generalOpacity, 255, 255, 0)),   // [0] Yellow
            new SolidBrush(Color.FromArgb(generalOpacity, 255, 0, 0)),     // [1] Red
            new SolidBrush(Color.FromArgb(generalOpacity, 0, 255, 0)),     // [2] Green
            new SolidBrush(Color.FromArgb(generalOpacity, 0, 0, 255)),     // [3] Blue
            new SolidBrush(Color.FromArgb(generalOpacity, 150, 0, 200)),   // [4] Violet
            new SolidBrush(Color.FromArgb(spacialOpacity, 255, 255, 255)), // [5] White
            new SolidBrush(Color.FromArgb(spacialOpacity, 0, 255, 255)),   // [6] Light Blue
            new SolidBrush(Color.FromArgb(spacialOpacity, 255, 0, 140))    // [7] Magenta
        };

        static public int GetCoorX(Form form, PictureBox deckPictureBox)
        {
            int borderWidth = (form.Width - form.ClientSize.Width) / 2;
            int coorX = Control.MousePosition.X - form.Location.X - deckPictureBox.Location.X - borderWidth;
            return (coorX < 33 || coorX > 342) ? -1 : coorX;
        }

        static public int GetCoorY(Form form, PictureBox deckPictureBox)
        {
            int borderWidth = (form.Width - form.ClientSize.Width) / 2;
            int titleBarHeight = form.Height - form.ClientSize.Height - 2 * borderWidth;
            int coorY = Control.MousePosition.Y - form.Location.Y - deckPictureBox.Location.Y - titleBarHeight - borderWidth;
            return (coorY < 33 || coorY > 342) ? -1 : coorY;
        }

        static public int GetCell(int coor)
        {
            return (coor - 33) / 31;
        }

        // PictureBox paint event handler for drawing a colored cell.
        static public void DrawColoredCell(int cellX, int cellY, int color, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Graphics.colors[color], (cellX + 1) * 31 + 1, (cellY + 1) * 31 + 1, 30, 30);
        }

        static public void DrawHitCell(int cellX, int cellY, Form form, PictureBox deckPictureBox)
        {
            System.Drawing.Graphics g = deckPictureBox.CreateGraphics();
            g.DrawImage(hitImage, (cellX + 1) * 31 + 1, (cellY + 1) * 31 + 1);
        }

        // PictureBox paint event handler for drawing a hit cell.
        static public void DrawHitCell(int cellX, int cellY, PaintEventArgs e)
        {
            e.Graphics.DrawImage(hitImage, (cellX + 1) * 31 + 1, (cellY + 1) * 31 + 1);
        }

        // PictureBox paint event handler for drawing a splash cell.
        static public void DrawSplashCell(int cellX, int cellY, PaintEventArgs e)
        {
            e.Graphics.DrawImage(splashImage, (cellX + 1) * 31 + 1, (cellY + 1) * 31 + 1);
        }

        static public void DrawInnerFrameCell(int cellX, int cellY, int color, Form form, PictureBox deckPictureBox)
        {
            System.Drawing.Graphics g = deckPictureBox.CreateGraphics();
            Pen framePen = new Pen(colors[color], 3);
            g.DrawRectangle(framePen, (cellX + 1) * 31 + 3, (cellY + 1) * 31 + 3, 25, 25);
        }

        static public void DrawOuterFrameCell(int cellX, int cellY, int color, Form form, PictureBox deckPictureBox)
        {
            System.Drawing.Graphics g = deckPictureBox.CreateGraphics();
            Pen framePen = new Pen(colors[color], 3);
            g.DrawRectangle(framePen, (cellX + 1) * 31 + -3, (cellY + 1) * 31 + -3, 37, 37);
        }

        // PictureBox paint event handler for drawing an outer frame around a cell.
        static public void DrawOuterFrameCell(int cellX, int cellY, int color, PaintEventArgs e)
        {
            Pen framePen = new Pen(colors[color], 3);
            e.Graphics.DrawRectangle(framePen, (cellX + 1) * 31 + -3, (cellY + 1) * 31 + -3, 37, 37);
        }

        // PictureBox paint event handler for drawing a ship set on a deck.
        static public void DrawShipSet(int[,] shipSet, PaintEventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (shipSet[x, y] != -1)
                    {
                        DrawColoredCell(x, y, shipSet[x, y], e);
                    }
                }
            }
        }

        // PictureBox paint event handler for drawing a deck status of all the cells.
        static public void DrawDeckStatus(bool[,] deckStatus, int[,] shipSet, PaintEventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (deckStatus[x, y])
                    {
                        if (shipSet[x, y] != -1)
                        {
                            DrawHitCell(x, y, e);
                        }
                        else
                        {
                            DrawSplashCell(x, y, e);
                        }
                    }
                }
            }
        }

        // PictureBox paint event handler for drawing sunken ships.
        static public void DrawSunkenShips(int[,] shipSet, int[] ShipLeftCells, PaintEventArgs e)
        {
            for (int currentShip = 0; currentShip < 5; currentShip++)
            {
                if (ShipLeftCells[currentShip] == 0)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        for (int y = 0; y < 10; y++)
                        {
                            if (shipSet[x, y] == currentShip)
                            {
                                DrawColoredCell(x, y, currentShip, e);
                            }
                        }
                    }
                }
            }
        }
    }
}
