using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Formatter
{
   public partial class Form1 : Form
   {
      private ResourceManager rm;

      private ToolStripStatusLabel label;

      private string decimalSeparator;
      private string amDesignator, pmDesignator, aDesignator, pDesignator;
      private string pattern;

      // Flags to indicate presence of error information in status bar
      bool valueInfo;
      bool formatInfo;

      private string[] numberFormats = {"C", "D", "E", "e", "F", "G", "N", "P", "R", "X", "x"};
      private const int DEFAULTSELECTION = 5;
      private string[] dateFormats = { "g", "d", "D", "f", "F", "g", "G", "M", "O", "R", "s", 
                                       "t", "T", "u", "U", "Y" };

      public Form1()
      {
         InitializeComponent();
         rm = new ResourceManager("Formatter.Resources", this.GetType().Assembly);
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         // Disable Value text box.
         OKButton.Enabled = false;

         // Add label to status bar.
         label = new ToolStripStatusLabel();
         ToolStripItem[] items = { label };
         this.StatusBar.Items.AddRange( items);

         // Get localized strings for user interface.
         this.Text = rm.GetString("WindowCaption");
         this.ValueLabel.Text = rm.GetString("ValueLabel");
         this.FormatLabel.Text = rm.GetString("FormatLabel");
         this.ResultLabel.Text = rm.GetString("ResultLabel");
         this.CulturesLabel.Text = rm.GetString("CultureLabel");
         this.NumberBox.Text = rm.GetString("NumberBoxText");
         this.DateBox.Text = rm.GetString("DateBoxText");
         this.OKButton.Text = rm.GetString("OKButtonText");

         // Populate CultureNames list box with culture names
      CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
      // Define a string array so that we can sort and modify the names.
      List<String> names = new List<String>();
      int currentIndex = 0;                    // Index of the current culture.

      foreach (var culture in cultures)
         names.Add(culture.Name);

      names.Sort();
      // Change the name of the invariant culture so it is human readable.
      names[0] = rm.GetString("InvariantCultureName");
      // Add the culture names to the list box.
      this.CultureNames.Items.AddRange(names.ToArray());

      // Make the current culture the selected culture.
      for (int ctr = 0; ctr < names.Count; ctr++) {
         if (names[ctr] == CultureInfo.CurrentCulture.Name) {
            currentIndex = ctr;
            break;
         }
      }
      this.CultureNames.SelectedIndex = currentIndex;

         // Get decimal separator.
         decimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;

         // Get am, pm designators.
         amDesignator = DateTimeFormatInfo.CurrentInfo.AMDesignator;
         if (amDesignator.Length >= 1)
            aDesignator = amDesignator.Substring(0, 1);
         else
            aDesignator = String.Empty;

         pmDesignator = DateTimeFormatInfo.CurrentInfo.PMDesignator;
         if (pmDesignator.Length >= 1)
            pDesignator = pmDesignator.Substring(0, 1);
         else
            pDesignator = String.Empty;

         // For regex pattern for date and time components.
         pattern = @"^\s*\S+\s+\S+\s+\S+(\s+\S+)?(?<!" + amDesignator + "|" + 
                   aDesignator + "|" + pmDesignator + "|" + pDesignator + @")\s*$";

         // Select NumberBox for numeric string and populate combo box.
         this.NumberBox.Checked = true;
      }

      private void NumberBox_CheckedChanged(object sender, EventArgs e)
      {
         if (this.NumberBox.Checked) {
            this.Result.Text = String.Empty;

            this.FormatStrings.Items.Clear();
            this.FormatStrings.Items.AddRange(numberFormats);
            this.FormatStrings.SelectedIndex = DEFAULTSELECTION;
         }
      }

      private void OKButton_Click(object sender, EventArgs e)
        {
            Execute();
        }

        private void Execute()
        {
            label.Text = "";
            this.Result.Text = String.Empty;

            // Get name of the current culture.
            CultureInfo culture = null;
            string cultureName = (string)this.CultureNames.Items[this.CultureNames.SelectedIndex];
            // If the selected culture is the invariant culture, change its name.
            if ( cultureName == rm.GetString("InvariantCultureName") )
                cultureName = String.Empty;
            culture = CultureInfo.CreateSpecificCulture(cultureName);

            foreach ( string txt in txtValue.Text.Replace("\r\n", "\n").Split('\n') )
            {
                try
                {
                    this.Result.Text += Format(txt, culture) + "\r\n";
                }
                catch ( FormatException ex )
                {
                    label.Text = ex.Message;
                    formatInfo = true;
                }
                catch ( ArgumentException ex )
                {
                    label.Text = ex.Message;
                    valueInfo = true;
                }
            }
        }

        private string Format(string txt, CultureInfo culture)
        {
            // Parse string as date
            if ( this.DateBox.Checked )
            {
                DateTime dat = DateTime.MinValue;
                DateTimeOffset dto = DateTimeOffset.MinValue;
                long ticks;
                bool hasOffset = false;

                // Is the date a number expressed in ticks?
                if ( Int64.TryParse(txt, out ticks) )
                {
                    dat = new DateTime(ticks);
                }
                else
                {
                    // Does the date have three components (date, time offset), or fewer than 3?
                    if ( Regex.IsMatch(txt, pattern, RegexOptions.IgnoreCase) )
                    {
                        if ( !DateTimeOffset.TryParse(txt, out dto) )
                            throw new ArgumentException(rm.GetString("MSG_InvalidDTO"));
                            hasOffset = true;
                        
                    }
                    else
                    {
                        // The string is to be interpeted as a DateTime, not a DateTimeOffset.
                        if ( DateTime.TryParse(txt, out dat) )
                        {
                            hasOffset = false;
                        }
                        else
                        {
                            throw new ArgumentException(rm.GetString("MSG_InvalidDate"));
                        }
                    }
                }            // Format date value.
                if ( hasOffset )
                    return dto.ToString(this.FormatStrings.Text, culture);
                else
                    return dat.ToString(this.FormatStrings.Text, culture);
            }
            else
            {
                // Handle formatting of a number.
                long intToFormat;
                BigInteger bigintToFormat = BigInteger.Zero;
                double floatToFormat;

                // Format a floating point value.
                if ( txt.Contains(decimalSeparator) )
                {
                    try
                    {
                        if ( !Double.TryParse(txt, out floatToFormat) )
                            throw new ArgumentException(rm.GetString("MSG_InvalidFloat"));
                        else
                            return floatToFormat.ToString(this.FormatStrings.Text, culture);
                    }
                    catch ( FormatException )
                    {
                        throw new FormatException(rm.GetString("MSG_InvalidFormat"));
                    }
                }
                else
                {
                    // Handle formatting an integer.
                    //
                    // Determine whether value is out of range of an Int64
                    if ( !BigInteger.TryParse(txt, out bigintToFormat) )
                    {
                        throw new ArgumentException(rm.GetString("MSG_InvalidInteger"));
                    }
                    else
                    {
                        // Format an Int64
                        if ( bigintToFormat >= Int64.MinValue && bigintToFormat <= Int64.MaxValue )
                        {
                            intToFormat = (long)bigintToFormat;
                            try
                            {
                                return intToFormat.ToString(this.FormatStrings.Text, culture);
                            }
                            catch ( FormatException )
                            {
                                throw new FormatException(rm.GetString("MSG_InvalidFormat"));
                            }
                        }
                        else
                        {
                            // Format a BigInteger
                            try
                            {
                                return bigintToFormat.ToString(this.FormatStrings.Text, culture);
                            }
                            catch ( FormatException )
                            {
                                throw new FormatException(rm.GetString("MSG_InvalidFormat"));
                            }
                        }
                    }
                }
            }
        }

        private void DateBox_CheckedChanged(object sender, EventArgs e)
      {
         if (this.DateBox.Checked) {
            this.Result.Text = String.Empty;

            this.FormatStrings.Items.Clear();
            this.FormatStrings.Items.AddRange(dateFormats);
            this.FormatStrings.SelectedIndex = DEFAULTSELECTION;
         }
      }

      private void txtValue_TextChanged(object sender, EventArgs e)
      {
         this.Result.Text = String.Empty;

         if (valueInfo) { 
            label.Text = String.Empty;
            valueInfo = false;
         }
            if ( String.IsNullOrEmpty(txtValue.Text) )
            {
                OKButton.Enabled = false;
            }
            else
            {
                OKButton.Enabled = true;
                if ( chkContinuous.Checked )
                    Execute();
            }
      }

      private void FormatStrings_SelectedIndexChanged(object sender, EventArgs e)
      {
         this.Result.Text = String.Empty;
         if (formatInfo) {
            label.Text = String.Empty;
            formatInfo = false;
         }
      }

      private void CultureNames_SelectedIndexChanged(object sender, EventArgs e)
      {
         this.Result.Text = String.Empty;
      }
   }
}
