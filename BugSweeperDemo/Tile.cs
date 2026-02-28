using System.Reflection;
using System.Reflection.Emit;
using Microsoft.Maui.Controls.Shapes;

namespace BugSweeperDemo;

enum TileStatus
{
    Hidden, 
    Flagged,
    Exposed
}

class Tile: Border
{
    TileStatus tileStatus = TileStatus.Hidden;

    Label label;

    Image flagImage, bugImage;

   bool doNotFireEvent;


#if WINDOWS
        bool lastTapSingle;
        DateTime lastTapTime;
#endif

    public event EventHandler<TileStatus> TileStatusChanged;

    public int Row { get; private set; }
    public int Col { get; private set; }
    public bool IsBug { get; set; }
    public int SurroundingBugCount { get; set; }
    
    public TileStatus Status
    {
        get => tileStatus;
        set
        {
            if (tileStatus != value)
            {
                tileStatus = value;

                switch (tileStatus)
                {
                    case TileStatus.Hidden:
                        this.Content = null;
                        break;

                    case TileStatus.Flagged:
                        this.Content = flagImage;
                        break;

                    case TileStatus.Exposed:
                        if (this.IsBug)
                            this.Content = bugImage;
                        else
                        {
                            this.Content = label;
                            label.Text = (this.SurroundingBugCount > 0) ? this.SurroundingBugCount.ToString() : " ";
                        }
                        break;
                }

                if (!doNotFireEvent && TileStatusChanged != null)
                    TileStatusChanged(this, tileStatus);
            }
        }
    }    
}
    