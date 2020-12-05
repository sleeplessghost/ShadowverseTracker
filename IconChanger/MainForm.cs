using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace IconChanger
{
    public partial class MainForm : Form
    {
        private readonly string DEFAULTEXENAME = "ShadowverseTracker.exe";
        private readonly int NUMICONS = 28;

        private readonly Color COLOR_BEIGE = ColorTranslator.FromHtml("#E6E2AF");
        private readonly Color COLOR_LIGHT_BLUE = ColorTranslator.FromHtml("#046380");
        private readonly Color COLOR_BACKGROUND = ColorTranslator.FromHtml("#192123");
        private readonly Color COLOR_BACKGROUND_PANEL = ColorTranslator.FromHtml("#223c46");
        private readonly Color COLOR_BUTTON = ColorTranslator.FromHtml("#295b6e");
        private readonly Color COLOR_IMAGE_BUTTON = ColorTranslator.FromHtml("#28424c");
        private readonly Color COLOR_IMAGE_BUTTON_SEL = ColorTranslator.FromHtml("#466d7c");

        private int mSelectedIcon = -1;
        private string mFilePath = "";
        private string mIconPath = "";

        private Button[] mButtonArray;
        private Icon[] mIconArray;
        private Bitmap[] mImageArray;

        public MainForm()
        {
            InitializeComponent();

            dialogBrowseFile.InitialDirectory = Directory.GetCurrentDirectory();
            dialogBrowseIcon.InitialDirectory = Directory.GetCurrentDirectory();
            btnBrowseFile.Click += new EventHandler(btnBrowse_Click);
            btnBrowseIcon.Click += new EventHandler(btnBrowseIcon_Click);
            btnSaveCustomIcon.Click += new EventHandler(btnSaveCustomIcon_Click);
            btnExit.Click += new EventHandler(btnExit_Click);
            btnSave.Click += new EventHandler(btnSave_Click);

            //check if ShadowverseTracker.exe is in current dir
            string guessedFile = Path.Combine(Directory.GetCurrentDirectory(), DEFAULTEXENAME);
            if (File.Exists(guessedFile))
            {
                updateFileText(guessedFile);
            }

            initArrays();
            customColours();
        }

        private void updateFileText(string text)
        {
            mFilePath = text;
            textFilePath.Text = mFilePath;
        }

        private void updateIconText(string text)
        {
            mIconPath = text;
            textIconPath.Text = mIconPath;
        }

        void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = dialogBrowseFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                updateFileText(dialogBrowseFile.FileName);
            }
        }

        void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            DialogResult result = dialogBrowseIcon.ShowDialog();
            if (result == DialogResult.OK)
            {
                updateIconText(dialogBrowseIcon.FileName);
            }
        }

        void btnSaveCustomIcon_Click(object sender, EventArgs e)
        {
            if (validFile())
            {
                if (validCustomIcon())
                {
                    try
                    {
                        IconInjector.InjectIconFromFile(mFilePath, mIconPath);
                        refreshIconCache();
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine("Exception occurred trying to set icon from file to file " + mFilePath + ", " + mIconPath + ", " + x.ToString());
                        MessageBox.Show("Setting custom icon failed.");
                    }
                }
            }
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (validFile())
            {
                if (iconSelected())
                {
                    try
                    {
                        Icon icon = getSelectedIcon();
                        IconInjector.InjectIconFromResource(mFilePath, icon);
                        refreshIconCache();
                    }
                    catch (Exception x)
                    {
                        Console.WriteLine("Exception occurred trying to set icon from resource to file " + mFilePath +", " + x.ToString());
                        MessageBox.Show("Setting icon failed.");
                    }
                }
            }
        }

        void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void btnIcon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < mButtonArray.Length; i++)
            {
                if (sender == mButtonArray[i])
                {
                    if (mSelectedIcon == i)
                    {
                        mSelectedIcon = -1;
                    }
                    else
                    {
                        mSelectedIcon = i;
                    }
                    updateButtons();
                    break;
                }
            }
        }

        private void updateButtons()
        {
            for (int i = 0; i < mButtonArray.Length; i++)
            {
                mButtonArray[i].BackColor = mSelectedIcon == i ? COLOR_IMAGE_BUTTON_SEL : COLOR_IMAGE_BUTTON;
            }
        }

        private bool validFile()
        {
            bool result = true;
            if (mFilePath == null || mFilePath.Length == 0)
            {
                result = false;
                MessageBox.Show("Please select an .exe to apply icon to.");
            }
            else if (!mFilePath.ToLower().EndsWith(".exe"))
            {
                result = false;
                MessageBox.Show("Please select a valid .exe file.");
            }
            else if (!File.Exists(mFilePath))
            {
                result = false;
                MessageBox.Show("Could not find selected .exe file, please select again.");
                updateFileText("");
            }
            return result;
        }

        private bool iconSelected()
        {
            bool result = true;
            if (mSelectedIcon == -1)
            {
                result = false;
                MessageBox.Show("Please select an icon");
            }
            return result;
        }

        private bool validCustomIcon()
        {
            bool result = true;
            if (mIconPath == null || mIconPath.Length == 0)
            {
                result = false;
                MessageBox.Show("Please select an .ico file to apply.");
            }
            else if (!mIconPath.ToLower().EndsWith(".ico"))
            {
                result = false;
                MessageBox.Show("Please select a valid .ico file.");
            }
            else if (!File.Exists(mIconPath))
            {
                result = false;
                MessageBox.Show("Could not find selected .ico file, please select again.");
                updateIconText("");
            }
            return result;
        }

        private Icon getSelectedIcon()
        {
            Icon icon = null;

            if (mSelectedIcon >= 0 && mSelectedIcon < mIconArray.Length)
            {
                icon = mIconArray[mSelectedIcon];
            }

            return icon;
        }

        private void initArrays()
        {
            mButtonArray = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7,
                                         btn8, btn9, btn10, btn11, btn12, btn13, btn14,
                                         btn15, btn16, btn17, btn18, btn19, btn20, btn21,
                                         btn22, btn23, btn24, btn25, btn26, btn27, btn28 };
            mIconArray = new Icon[] { Properties.Resources.ic_daria1, Properties.Resources.ic_daria2, Properties.Resources.ic_daria3, Properties.Resources.ic_daria4,
                                      Properties.Resources.ic_date1, Properties.Resources.ic_ding1, Properties.Resources.ic_ding2, Properties.Resources.ic_ding3,
                                      Properties.Resources.ic_forte1, Properties.Resources.ic_forte2, Properties.Resources.ic_forte3, Properties.Resources.ic_forte4,
                                      Properties.Resources.ic_hamsa1, Properties.Resources.ic_luna1, Properties.Resources.ic_luna2, Properties.Resources.ic_luna3,
                                      Properties.Resources.ic_luna4, Properties.Resources.ic_luna5, Properties.Resources.ic_luna6, Properties.Resources.ic_luna7,
                                      Properties.Resources.ic_luna8, Properties.Resources.ic_mordecai1, Properties.Resources.ic_vampy1, Properties.Resources.ic_vampy2,
                                      Properties.Resources.ic_vampy3, Properties.Resources.ic_vampy4, Properties.Resources.ic_vampy5, Properties.Resources.ic_vampy6 };
            mImageArray = new Bitmap[] { Properties.Resources.img_daria1, Properties.Resources.img_daria2, Properties.Resources.img_daria3, Properties.Resources.img_daria4,
                                         Properties.Resources.img_date1, Properties.Resources.img_ding1, Properties.Resources.img_ding2, Properties.Resources.img_ding3,
                                         Properties.Resources.img_forte1, Properties.Resources.img_forte2, Properties.Resources.img_forte3, Properties.Resources.img_forte4,
                                         Properties.Resources.img_hamsa1, Properties.Resources.img_luna1, Properties.Resources.img_luna2, Properties.Resources.img_luna3,
                                         Properties.Resources.img_luna4, Properties.Resources.img_luna5, Properties.Resources.img_luna6, Properties.Resources.img_luna7,
                                         Properties.Resources.img_luna8, Properties.Resources.img_mordecai1, Properties.Resources.img_vampy1, Properties.Resources.img_vampy2,
                                         Properties.Resources.img_vampy3, Properties.Resources.img_vampy4, Properties.Resources.img_vampy5, Properties.Resources.img_vampy6 };
            if (mButtonArray.Length != NUMICONS || mIconArray.Length != NUMICONS || mImageArray.Length != NUMICONS)
            {
                Console.WriteLine("Incorrect number of buttons/icons/images [Button:" + mButtonArray.Length + "] [Icon:" + mIconArray.Length + "] [Image:" + mImageArray.Length+"]");
                MessageBox.Show("Failed to load buttons/images :(");
            }
            else
            {
                Button btn;
                Bitmap img;
               
                for (int i = 0; i < NUMICONS; i++)
                {
                    btn = mButtonArray[i];
                    img = mImageArray[i];
                    btn.BackgroundImage = img;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    btn.Click += new EventHandler(btnIcon_Click);
                }
            }
        }

        /* refresh icon cache */
        [System.Runtime.InteropServices.DllImport("Shell32.dll")]
        private static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

        private readonly int SHCNE_ASSOCCHANGED = 0x08000000;
        private readonly int SHCNF_FLUSH = 0x1000;
        private readonly int SHCNF_IDLIST = 0;

        private void refreshIconCache()
        {
            SHChangeNotify(SHCNE_ASSOCCHANGED, SHCNF_IDLIST | SHCNF_FLUSH, IntPtr.Zero, IntPtr.Zero); 
        }

        /* Custom Colours */
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
          IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection pfc = new PrivateFontCollection();

        private void customColours()
        {
            try
            {
                unsafe
                {
                    fixed (byte* pFontData = Properties.Resources.roboto)
                    {
                        uint dummy = 0;
                        pfc.AddMemoryFont((IntPtr)pFontData, Properties.Resources.roboto.Length);
                        AddFontMemResourceEx((IntPtr)pFontData, (uint)Properties.Resources.roboto.Length, IntPtr.Zero, ref dummy);
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("failed to load font " + x.ToString());
            }
            Font defFont = pfc.Families.Length > 0 ? new Font(pfc.Families[0], 9, FontStyle.Bold) : new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);

            updateButtons();
            this.BackColor = COLOR_BACKGROUND;
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    control.BackColor = COLOR_BACKGROUND_PANEL;
                }
            }
            foreach (Control control in this.panelBrowse.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                    ((Button)control).FlatAppearance.BorderSize = 0;
                }
                else if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is TextBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
            foreach (Control control in this.panelButtons.Controls)
            {
                if (control is Button)
                {
                    ((Button)control).FlatAppearance.BorderColor = COLOR_BACKGROUND_PANEL;
                    ((Button)control).FlatAppearance.BorderSize = 7;
                }
            }
            foreach (Control control in this.panelCustomIcon.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                    ((Button)control).FlatAppearance.BorderSize = 0;
                }
                else if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is TextBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
            foreach (Control control in this.panelSave.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = COLOR_BUTTON;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                    ((Button)control).FlatAppearance.BorderSize = 0;
                }
                else if (control is Label)
                {
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
                else if (control is TextBox)
                {
                    control.BackColor = COLOR_LIGHT_BLUE;
                    control.ForeColor = COLOR_BEIGE;
                    control.Font = defFont;
                }
            }
        }
    }
}
