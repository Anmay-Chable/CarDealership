﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearlyAcademicPlan
{
    /// <summary>
    /// Class <c>Validation</c> contains methods that check for various types of user input to prevent errors.
    /// </summary>
    public static class Validation
    {
        private static string requiredTextField = " is a required field.";
        private static string requiredComboField = " is a required field. Please make a selection.";

        #region Text Box

        /// <summary>
        /// Used to verify a textbox is not empty.
        /// </summary>
        /// <param name="name">The name of the text field</param>
        /// <param name="box">The textbox that is selected</param>
        /// <returns>True if textbox is not empty, false and an error message if it is empty.</returns>
        public static bool IsTextboxFilled(string name, TextBox box)
        {
            if (box.Text == "")
            {
                MessageBox.Show(name + requiredTextField, "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box.Focus();
                return false;
            }

            return true;
        }

        #endregion

        #region Combo Box

        /// <summary>
        /// Used to verify if a non-typeable dropdown has a selected value.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="box"></param>
        /// <returns>True if drowpdown has been selected, false and an error message if it is left unselected.</returns>
        public static bool IsComboSelected(string name, ComboBox box)
        {
            if (box.SelectedItem == null)
            {
                MessageBox.Show(name + requiredComboField, "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box.Focus();
                return false;
            }

            return true;
        }

        #endregion
    }
}
