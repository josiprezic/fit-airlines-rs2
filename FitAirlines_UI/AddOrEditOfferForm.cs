using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines_UI
{
    public enum AddOrEditOfferFormType 
    { 
        Add,
        Edit
    }

    public partial class AddOrEditOfferForm : BaseForm
    {
        //
        // MARK: - Variables
        //

        AddOrEditOfferFormType type;

        //
        // MARK: - Constructors
        //

        public AddOrEditOfferForm(AddOrEditOfferFormType type = AddOrEditOfferFormType.Add)
        {
            this.type = type;
            InitializeComponent();
        }

        //
        // MARK: - JR 
        //
    }
}
