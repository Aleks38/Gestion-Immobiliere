using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_TP.Data.DAL;
using WPF_TP.Data.Models;
using WPF_TP.Views;

namespace WPF_Exo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new NavigationView();

            //ImoContext ctx = new ImoContext();
            //ctx.Biens.Add(new Box("ahahah","testadresse", 20, 30));
            //ctx.SaveChanges();

            //Question 5 à finir 
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .WriteTo.File("../../../log/log.txt", outputTemplate: "[{Timestamp:dd/MM/yyyy} {Level:u3}] {Message:lj}{NewLine}{Exception}", rollingInterval: RollingInterval.Day)
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Debug)
                .CreateLogger();

            Log.Logger.Information("Message à afficher");


            string nomFichier()
            {
                string date  = DateTime.Now.ToString("dd-MM");

                string nom = "log-" + date;

                return nom;
            }
        }
    }
}
