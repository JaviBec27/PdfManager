using SwDividePDF.Presentación.Style.StyleCase;
using System;
using System.Windows.Forms;

namespace SwDividePDF.Presentación
{
    public partial class Information : MainForm
    {
        int _count;
        public Information() : base()
        {
            _count = 0;
            InitializeComponent();
            ApplyGlobalStyles();
        }



        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void btnThema_Primary_Click(object sender, EventArgs e)
        {

            switch (_count)
            {
                case 0:
                    base._globalStyleStrategy = new DarkStyle();
                    break;
                case 1:
                    base._globalStyleStrategy = new LightStyle();
                    break;
                case 2:
                    base._globalStyleStrategy = new BlueCore();
                    break;
                case 3:
                    _globalStyleStrategy = new GreenRainDay();
                    _count = -1;
                    break;
                default:
                    base._globalStyleStrategy = new BlueCore();
                    break;
            }

            _count++;
            ApplyGlobalStyles();

        }

        protected override void ApplyGlobalStyles()
        {
            base.styleContext.SetStyleStrategy(base._globalStyleStrategy);
            base.styleContext.ApplyStyle(this);
           
            base.ApplyGlobalStyles();
        }
    }
}
