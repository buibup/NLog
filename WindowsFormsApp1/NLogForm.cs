using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NLogForm : Form
    {
        public Logger logger { get; set; } = LogManager.GetLogger("databaseLogger");
        public NLogForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                logger.Info("starting!");
                int zero = 0;
                int result = 5 / zero;
            }
            catch (DivideByZeroException ex)
            {
                // get a Logger object and log exception here using NLog. 
                // this will use the "databaseLogger" logger from our NLog.config file
                

                // add custom message and pass in the exception
                logger.Error(ex, "Whoops!");
            }

        }

        private void traceButton_Click(object sender, EventArgs e)
        {
            logger.Trace("Trace Log");
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            logger.Debug("Debug Log");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            logger.Info("Info Log");
        }

        private void warnButton_Click(object sender, EventArgs e)
        {
            logger.Warn("Warn Log");
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            logger.Error("Error Log");
        }

        private void fatalButton_Click(object sender, EventArgs e)
        {
            logger.Fatal("Fatal Log");
        }
    }
}
