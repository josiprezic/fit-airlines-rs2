using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    public partial class BaseDataGridView : DataGridView
    {

        //
        // MARK: - Constructors
        //

        public BaseDataGridView()
        {
            InitializeComponent();
        }

        public BaseDataGridView(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        //
        // MARK: - Protected methods
        //

        protected void SetupStyling()
        {
            BackgroundColor = Color.White;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Configure();
        }

        //
        // MARK: - Private methods
        //

        void Configure() 
        {
            BaseSetup();
            SetupStyling();
        }

        void BaseSetup() 
        {
            ReadOnly = true;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MultiSelect = false;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllowUserToResizeRows = false;
            AllowUserToResizeColumns = false;
            AllowUserToAddRows = false;
            AllowDrop = false;
            RowTemplate.Height = 35;
        }

        //
        // MARK: - Public methods
        //

        public void showSelectedColumns(List<string> columns)
        {
            foreach (DataGridViewColumn column in Columns)
            {
                column.Visible = columns.Contains(column.Name);
            }
        }
    }
}
