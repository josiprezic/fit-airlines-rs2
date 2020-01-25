using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Diagnostics;

namespace FitAirlines_UI
{
    public class BaseForm: Form
    {
        protected BaseForm() { }

        override protected void OnLoad(EventArgs e) { Configure(); }

        protected virtual void SetupStrings() { }

        protected virtual void SetupStyling() { }

        protected void Logger(String message) { Debug.WriteLine(message); }

        protected void Configure()
        {
            SetupStrings();
            SetupStyling();
        }

        protected String GetString(String key)
        {
            var resources = new ResourceManager(this.GetType());
            String result = resources.GetString(key);

            if (result == null)
            {
                Logger(this.GetType().Name + ": Error while getting string for key:" + key);
                return "KeyNotFound:" + key;
            }
            return result;
        }
    }
}
