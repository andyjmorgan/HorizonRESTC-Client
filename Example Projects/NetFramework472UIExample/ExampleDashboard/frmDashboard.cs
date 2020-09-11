using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private async void tmrRefresh_Tick(object sender, EventArgs e)
        {
          
            /// this is a bit overkill, but refresh token each poll
            /// 
            SharedObjects._Client.RefreshToken();

            /// pull the session table for updating the dashboards
            var sessions = await SharedObjects._Client.Inventory.ListSessionInfoAsync();


            /// filter session state by type
            var Connected = sessions.Where(x => x.SessionState == VMware.Horizon.RESTAPI.Model.SessionInfo.SessionStateEnum.CONNECTED && x.IdleDuration <= 3).Count();
            var idle = sessions.Where(x => x.SessionState == VMware.Horizon.RESTAPI.Model.SessionInfo.SessionStateEnum.CONNECTED && x.IdleDuration > 3).Count();
            var Disconnected = sessions.Where(x => x.SessionState == VMware.Horizon.RESTAPI.Model.SessionInfo.SessionStateEnum.DISCONNECTED).Count();
            var Pending = sessions.Where(x => x.SessionState == VMware.Horizon.RESTAPI.Model.SessionInfo.SessionStateEnum.PENDING).Count();


            /// filter sessions by session type
            var ApplicationSessions = sessions.Where(x => x.SessionType == VMware.Horizon.RESTAPI.Model.SessionInfo.SessionTypeEnum.APPLICATION).ToList();
            var DesktopSessions = sessions.Where(x => x.SessionType != VMware.Horizon.RESTAPI.Model.SessionInfo.SessionTypeEnum.APPLICATION).ToList();

            pcSessionType.Series.Clear();
            pcSessionType.Series.Add(new PieSeries
            {
                Title = "Desktops",
                DataLabels = false,
                Values = new ChartValues<double> { DesktopSessions.Count() },

            });

            pcSessionType.Series.Add(new PieSeries
            {
                Title = "Apps",
                DataLabels = false,
                Values = new ChartValues<double> { ApplicationSessions.Count() },

            });
            pcSessionType.LegendLocation = LegendLocation.Bottom;


            /// build to 5 views
            var Top5Desktops = DesktopSessions.GroupBy(x => x.DesktopPoolId).OrderByDescending(x => x.Count()).Take(5);
            var Top5Applications = ApplicationSessions.SelectMany(x => x.ApplicationNames).GroupBy(x => x).Select(group => new { count = group.Count(), key = group.Key }).OrderByDescending(x=> x.count).ToList();
            pcTop5Desktops.Series.Clear();
            foreach(var Desktop in Top5Desktops)
            {
                var DesktopDetails = await SharedObjects._Client.Inventory.GetDesktopPoolAsync(Desktop.Key);
                pcTop5Desktops.Series.Add(new PieSeries
                {
                    Title = DesktopDetails.DisplayName,
                    Values = new ChartValues<double> { Desktop.Count() },
                    DataLabels = false,

                });
            }
            pcTop5Desktops.LegendLocation = LegendLocation.Bottom;

            pcTop5Applications.Series.Clear();
            foreach (var app in Top5Applications)
            {
                //var DesktopDetails = await SharedObjects._Client.Inventory.GetDesktopPoolAsync(Desktop.Key);
                pcTop5Applications.Series.Add(new PieSeries
                {
                    Title = app.key,
                    Values = new ChartValues<double> { app.count },
                    DataLabels = false,

                });
            }
            pcTop5Applications.LegendLocation = LegendLocation.Bottom;


            pcUserSessions.Series.Clear();


            pcUserSessions.Series.Add(new PieSeries
            {
                Title = "Connected",
                Values = new ChartValues<double> { Connected },
                DataLabels = false,
            });

            pcUserSessions.Series.Add(new PieSeries
            {
                Title = "Idle",
                Values = new ChartValues<double> { idle },
                DataLabels = false,
            });

            pcUserSessions.Series.Add(new PieSeries
            {
                Title = "Disconnected",
                Values = new ChartValues<double> { Disconnected },
                DataLabels = false,
            });
            pcUserSessions.Series.Add(new PieSeries
            {
                Title = "Pending",
                Values = new ChartValues<double> { Pending },
                DataLabels = false,
            });

            pcUserSessions.LegendLocation = LegendLocation.Bottom;

            pcProtocol.Series.Clear();

            var ProtocolGroup = sessions.GroupBy(x => x.SessionProtocol);
            foreach(var protocol in ProtocolGroup)
            {
                if(protocol.Key !=null)
                {
                    PieSeries ProtocolSeries = new PieSeries
                    {
                        Title = protocol.Key.ToString(),
                        Values = new ChartValues<double> { protocol.Count() },
                        DataLabels = false,
                    };
                    pcProtocol.Series.Add(ProtocolSeries);

                }
            }
            pcProtocol.LegendLocation = LegendLocation.Bottom;            
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            tslConnectionName.Text = SharedObjects._Client.GetConnectionURI().Host;
            tmrRefresh_Tick(null,null);

            tmrRefresh.Enabled = true;
        }
    }
}
