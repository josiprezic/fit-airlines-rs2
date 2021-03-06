﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitAirlines.UI
{
    public partial class BaseComboBox : ComboBox
    {
        
        //
        // MARK: - Constructors
        //

        public BaseComboBox()
        {
            InitializeComponent();
        }

        //
        // MARK: - Protected methods
        //

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Configure();
        }

        protected virtual void SetupStyling()
        {
           
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
            DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // magia szefowa
        public void SetSelectedItem<T>(Func<T, bool> action)
        {
            foreach (T item in this.Items)
            {
                if (action(item) == true)
                {
                    this.SelectedItem = item;
                    break;
                }
            }
        }

    }
}
