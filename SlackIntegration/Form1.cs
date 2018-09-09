using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlackIntegration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSlack_Click(object sender, EventArgs e)
        {
            string urlWithAccessToken = "https://hooks.slack.com/services/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";
            SlackClient slackClient = new SlackClient(urlWithAccessToken);
            var slackMessage = new SlackMessage
            {
                Text = "yazılım Test Mesajı!",
                IconEmoji = Emoji.Angry,
                Username = "Mesut Kaya"
            };
            slackClient.Post(slackMessage);
        }
    }
}
